using System;
using System.Collections.Generic;
using System.Drawing;
using PixelClicker.Core;
using PixelClicker.Interfaces;
using PixelClicker.Model;
using PixelClicker.Types;

namespace PixelClickerPrototype
{
    public class HealthBar : PixelClicker.Core.TaskBitmap
    {
        public HealthBar(IBitmapSettings settings, IAction action) : base(settings, action)
        {
            /*  
             */
        }

        public int GetYFromByte(int n, int x, int width)
        {
            return (n - x) / width;
        }

        public int GetXFromByte(int n, int width)
        {
            return n % width;
        }

        public override IActionProperty CheckCondition(ref LockBitmap lockBitmap)
        {
            ActionProperty actionModel = new ActionProperty();
            byte[] pixels = lockBitmap.Pixels;
            var castSettings = ((PixelClickerPrototype.Settings)Settings);
            int width = lockBitmap.Width;
            var points = new List<DbscanPoint>();

            for (var n = pixels.Length - 1; n >= 0; n--)
            {
                var nMultiplied = n * 4;
                if (nMultiplied >= pixels.Length)
                    continue;

                if (!(pixels[nMultiplied + 2] >= 250 && pixels[nMultiplied + 1] <= 5 && pixels[nMultiplied] <= 20))
                {
                    continue;
                }

                var x = GetXFromByte(n, width);
                var y = GetYFromByte(n, x, width);

                points.Add(new DbscanPoint(x, y));
            }

            if (points.Count == 0) return actionModel;
            var heightAdjusted = Settings.SearchMethod != SearchMethod.AnyWhere ? 1.75 : 1;
            HighestLowest target = CalculateTarget(points, heightAdjusted);

            if (target == null) return actionModel;
            
            
            int healthBarHeight = GetHealthBarHeight(target, castSettings.MaximumHealthBarHeight);

            int offset = (castSettings.MaximumHealthBarHeight - healthBarHeight) * 4;

            actionModel.RelativeToScreenPoint =
                new Point(Settings.SearchPosition.X + target.HighestPoint.X,
                    Settings.SearchPosition.Y + target.HighestPoint.Y);

            actionModel.AimPoint = new Point(target.HighestPoint.X + (castSettings.XOffset - offset),
                target.HighestPoint.Y + (castSettings.YOffset - offset));

            actionModel.Settings = castSettings;
            actionModel.DoAction = true;
            actionModel.Time = DateTime.Now;
            actionModel.PointsInfo = target;
            
            
            return actionModel;
        }

        private HighestLowest CalculateTarget(List<DbscanPoint> points, double heightAdjusted)
        {
            List<HighestLowest> highestLowestList = new List<HighestLowest>();
            var clusterCount = DbscanAlgorithm.Dbscan(points.ToArray(), 45, 2);
            if (clusterCount == 0)
                return null;

            for (var i = 0; i <= clusterCount - 1; i++)
            {
                highestLowestList.Add(new HighestLowest { Id = i });
            }

            int clusterIdClosestToMiddle = 0;
            int clusterClosestToMiddleDistance = int.MaxValue;
            var castSettings = ((PixelClickerPrototype.Settings)Settings);

            foreach (var pointLoopVariable in points)
            {
                var point = pointLoopVariable;
                if (point.ClusterId == null || point.IsNoise)
                    continue;

                if (point.X < highestLowestList[(int)(point.ClusterId - 1)].HighestPoint.X)
                    highestLowestList[(int)(point.ClusterId - 1)].HighestPoint.X = point.X;

                if (point.Y < highestLowestList[(int)(point.ClusterId - 1)].HighestPoint.Y)
                    highestLowestList[(int)(point.ClusterId - 1)].HighestPoint.Y = point.Y;

                if (point.X > highestLowestList[(int)(point.ClusterId - 1)].LowestPoint.X)
                    highestLowestList[(int)(point.ClusterId - 1)].LowestPoint.X = point.X;

                if (point.Y > highestLowestList[(int)(point.ClusterId - 1)].LowestPoint.Y)
                    highestLowestList[(int)(point.ClusterId - 1)].LowestPoint.Y = point.Y;

                int dis = DistanceBetween(new Point(Settings.SearchArea.Width / 2, (int)(Settings.SearchArea.Height / 2 * heightAdjusted)), new Point(point.X + castSettings.XOffset, point.Y + castSettings.YOffset));

                if (dis < clusterClosestToMiddleDistance)
                {
                    clusterClosestToMiddleDistance = dis;
                    clusterIdClosestToMiddle = (int)(point.ClusterId - 1);
                }

                highestLowestList[(int)(point.ClusterId - 1)].Points.Add(new Point(point.X,point.Y));
            }

            return highestLowestList[clusterIdClosestToMiddle];
        }

        private int GetHealthBarWidth(HighestLowest target)
        {
            return Math.Abs(target.HighestPoint.X - target.LowestPoint.X);
        }
        private int GetHealthBarHeight(HighestLowest target, int maxHeight)
        {
            int healthBarHeight = Math.Abs(target.HighestPoint.Y - target.LowestPoint.Y);
            return healthBarHeight >= maxHeight ? maxHeight : healthBarHeight;
        }
        public override Bitmap Draw(ref Bitmap bitmap)
        {
            return null;
            //throw new NotImplementedException();
        }
    }

    public class HighestLowest
    {
        public int Id;
        public List<Point> Points = new List<Point>();
        public Point HighestPoint = new Point(int.MaxValue, int.MaxValue);
        public Point LowestPoint = new Point(0, 0);
    }
    /// <summary>
    /// Contains an implementation of the DBSCAN algorithm. This class cannot be inherited.
    /// </summary>
    public class DbscanAlgorithm
    {

        #region "constructors"

        private DbscanAlgorithm()
        {
        }

        #endregion

        #region "methods"

        /// <summary>
        /// Clusters the specified points using the specified value and minimum points to form a cluster.
        /// </summary>
        /// <param name="points">The points to cluster.</param>
        /// <param name="eps">The value to use to find neighoring points.</param>
        /// <param name="minimumClusterCount">The minimum number of points to form a cluster.</param>
        /// <returns>The number of clusters created from the collection.</returns>
        public static int Dbscan<XType, YType>(IDbscanPoint<XType, YType>[] points, int eps, int minimumClusterCount)
        {
            int cid = 0;

            foreach (IDbscanPoint<XType, YType> p in points)
            {
                if (!p.IsVisited)
                {
                    p.IsVisited = true;

                    IDbscanPoint<XType, YType>[] neighbors = DbscanAlgorithm.GetNeighors(points, p, eps);

                    if (neighbors.Length < minimumClusterCount)
                    {
                        p.IsNoise = true;
                    }
                    else
                    {
                        cid += 1;
                        DbscanAlgorithm.ExpandCluster(points, p, neighbors, cid, eps, minimumClusterCount);
                    }
                }
            }

            return cid;
        }

        private static void ExpandCluster<XType, YType>(IDbscanPoint<XType, YType>[] points, IDbscanPoint<XType, YType> p, IDbscanPoint<XType, YType>[] neighbors, int cid, int eps, int minimumClusterCount)
        {
            p.ClusterId = cid;

            Queue<IDbscanPoint<XType, YType>> q = new Queue<IDbscanPoint<XType, YType>>(neighbors);

            while (q.Count > 0)
            {
                IDbscanPoint<XType, YType> n = q.Dequeue();
                if (!n.IsVisited)
                {
                    n.IsVisited = true;

                    IDbscanPoint<XType, YType>[] ns = DbscanAlgorithm.GetNeighors(points, n, eps);
                    if (ns.Length >= minimumClusterCount)
                    {
                        foreach (IDbscanPoint<XType, YType> item in ns)
                        {
                            q.Enqueue(item);

                        }
                    }
                }
                else if (!n.ClusterId.HasValue)
                {
                    n.ClusterId = cid;
                }
            }
        }

        private static IDbscanPoint<XType, YType>[] GetNeighors<XType, YType>(IDbscanPoint<XType, YType>[] points, IDbscanPoint<XType, YType> point, int eps)
        {
            List<IDbscanPoint<XType, YType>> neighbors = new List<IDbscanPoint<XType, YType>>();
            neighbors.Add(point);

            foreach (IDbscanPoint<XType, YType> p in points)
            {
                if (point.IsNeighbor(p, eps))
                {
                    neighbors.Add(p);
                }
            }

            return neighbors.ToArray();
        }

        #endregion
    }

    /// <summary>
    /// Contains an implementation of the <see cref="IDbscanPoint"/> interface 
    /// using <see cref="double"/> types for the X and Y components.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("\\{X={X}, Y={Y}\\}")]
    public class DbscanPoint : IDbscanPoint<int, int>
    {

        #region "properties"

        /// <summary>
        /// Gets or sets the X component of the point.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y component of the point.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the point is noise.
        /// </summary>
        public bool IsNoise { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the point was visited.
        /// </summary>
        public bool IsVisited { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the cluster id.
        /// </summary>
        public int? ClusterId { get; set; }

        #endregion

        #region "constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="DbscanPoint"/> class.
        /// </summary>
        public DbscanPoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DbscanPoint"/> class with the specified values.
        /// </summary>
        /// <param name="x">The X component of the point.</param>
        /// <param name="y">The Y component of the point.</param>
        public DbscanPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        #endregion

        #region "methods"

        /// <summary>
        /// Determines whether the specified point neighbors the current instance using the specified value.
        /// </summary>
        /// <param name="point">The point to test as a neighor.</param>
        /// <param name="eps">The value to use to find neighoring points.</param>
        /// <returns>True if the point is a neighbor; otherwise, false.</returns>
        public bool IsNeighbor(IDbscanPoint<int, int> point, double eps)
        {
            int dis = TaskBitmap.DistanceBetween(new Point(point.X, point.Y), new Point(this.X, this.Y));

            return dis < eps;
        }

        #endregion
    }

    /// <summary>
    /// Contains the functionality an object requires to perform a DBSCAN.
    /// </summary>
    public interface IDbscanPoint<XType, YType>
    {

        #region "properties"

        /// <summary>
        /// Gets or sets the X component of the point.
        /// </summary>

        XType X { get; set; }

        /// <summary>
        /// Gets or sets the Y component of the point.
        /// </summary>

        YType Y { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the point is noise.
        /// </summary>

        bool IsNoise { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the point was visited.
        /// </summary>

        bool IsVisited { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the cluster id.
        /// </summary>

        int? ClusterId { get; set; }

        #endregion

        #region "methods"

        /// <summary>
        /// Determines whether the specified point neighbors the current instance using the specified value.
        /// </summary>
        /// <param name="point">The point to test as a neighor.</param>
        /// <param name="eps">The value to use to find neighoring points.</param>
        /// <returns>True if the point is a neighbor; otherwise, false.</returns>
        bool IsNeighbor(IDbscanPoint<XType, YType> point, double eps);

        #endregion
    }
}
