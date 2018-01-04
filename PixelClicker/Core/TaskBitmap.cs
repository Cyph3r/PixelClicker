using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using PixelClicker.Interfaces;
using PixelClicker.Model;

namespace PixelClicker.Core
{
    public abstract class TaskBitmap : Task, ITaskBitmap
    {
        public new IBitmapSettings Settings { get; set; }
        public abstract IActionProperty CheckCondition(ref LockBitmap lockBitmap);
        public abstract Bitmap Draw(ref Bitmap bitmap);

        private readonly BackgroundWorker _bgworker;
        private static readonly Capture ScreenCapture = new Capture();
        private readonly Stopwatch _fpsStopWatch = new Stopwatch();
        private int _fps = 0;

        public TaskBitmap(IBitmapSettings settings, IAction action) : base(settings, action)
        {
            Settings = settings;
            _bgworker = new BackgroundWorker();
            _bgworker.DoWork += PreProcess;
        }

        public void Start()
        {
            ScreenCapture.NewImage += Notify;
            _fpsStopWatch.Start();
            ScreenCapture.Start();
        }

        public void Cancel()
        {
            ScreenCapture.NewImage -= Notify;
            _fpsStopWatch.Stop();
            ScreenCapture.Cancel();
        }

        public bool IsBusy()
        {
            return _bgworker.IsBusy;
        }

        public void Notify(Bitmap bitmap)
        {
            if (!_bgworker.IsBusy)
            {
                try
                {
                    _bgworker.RunWorkerAsync(bitmap);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            else
            {
                Debug.WriteLine("busy");
            }
        }


        private void PreProcess(object sender, DoWorkEventArgs e)
        {
            var lockBitmapModel = new LockBitmap(SnipImage((Bitmap) e.Argument));
            
            lockBitmapModel.LockBits();
            var actionModel = CheckCondition(ref lockBitmapModel);

            if (ActiveWindow.Name.ToLower().Contains(Settings.WindowName.ToLower()))
                Action.DoAction(actionModel);


            lockBitmapModel.UnlockBits();

            Bitmap drawBitmap = null;

            if (Settings.Draw)
            {
                drawBitmap = new Bitmap(lockBitmapModel.Source);
                Draw(ref drawBitmap);
            }

            _fps += 1;
            if (_fpsStopWatch.ElapsedMilliseconds >= 1000)
            {
                Settings.LastFps = _fps;
                _fps = 0;
                _fpsStopWatch.Restart();
            }

            lockBitmapModel.Dispose();
            drawBitmap?.Dispose();
        }

        private Bitmap SnipImage(Bitmap bitmap)
        {
            if (Settings.SearchPosition.Equals(Tasks.HeightestSearchPosition) && Settings.SearchArea.Equals(Tasks.MaxSearchArea)) return bitmap;

            Bitmap b = new Bitmap(Settings.SearchArea.Width, Settings.SearchArea.Height);

            Rectangle fromRectangle = new Rectangle(Settings.SearchPosition.X - Tasks.HeightestSearchPosition.X,
                Settings.SearchPosition.Y - Tasks.HeightestSearchPosition.Y,
                Settings.SearchArea.Width, Settings.SearchArea.Height);

            Rectangle toRectangle = new Rectangle(0, 0, Settings.SearchArea.Width, Settings.SearchArea.Height);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.DrawImage(bitmap, toRectangle, fromRectangle, GraphicsUnit.Pixel);
            }

            bitmap.Dispose();
            return new Bitmap(b);
        }

        public bool ColorIsInRange(int[] color)
        {
            try
            {
                foreach (ISearchColor col in Settings.SearchColors)
                {
                    if (color[0] >= col.R - col.ShadeVariation &&
                        color[0] <= col.R + col.ShadeVariation &&
                        color[1] >= col.G - col.ShadeVariation &&
                        color[1] <= col.G + col.ShadeVariation &&
                        color[2] >= col.B - col.ShadeVariation &&
                        color[2] <= col.B + col.ShadeVariation)
                    {
                        return true;
                    }

                }

            }
            catch
            {
                // ignored
            }

            return false;
        }

        public static int DistanceBetween(Point point1, Point point2)
        {
            // Calculate the distance between two points, given their X/Y coordinates.
            return (point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y);
        }
    }
}
