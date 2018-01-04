using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PixelClicker.Interfaces;
using PixelClicker.Types;

namespace PixelClicker.Extensions
{
    internal static class TasksExtension
    {
        public static void UpdateTaskSize(this List<ITask> tasks)
        {
            if (tasks.Count == 0) return;
            Point mostTopLeftPoint = new Point(int.MaxValue, int.MaxValue);
            Point mostBottomRightPoint = new Point(0, 0);
            Point cursorPosition = Cursor.Position;

            foreach (ITask task in tasks)
            {
                if (!(task is ITaskBitmap)) continue;

                ITaskBitmap convertedTask = (ITaskBitmap) task;

                if (convertedTask.Settings.SearchMethod == SearchMethod.CursorPosition)
                    convertedTask.Settings.SearchPosition = cursorPosition;


                if (convertedTask.Settings.SearchPosition.X < mostTopLeftPoint.X)
                {
                    mostTopLeftPoint.X = convertedTask.Settings.SearchPosition.X;
                }

                if (convertedTask.Settings.SearchPosition.Y < mostTopLeftPoint.Y)
                {
                    mostTopLeftPoint.Y = convertedTask.Settings.SearchPosition.Y;
                }

                if (convertedTask.Settings.SearchPosition.X + convertedTask.Settings.SearchArea.Width > mostBottomRightPoint.X)
                {
                    mostBottomRightPoint.X = convertedTask.Settings.SearchPosition.X + convertedTask.Settings.SearchArea.Width;
                }

                if (convertedTask.Settings.SearchPosition.Y + convertedTask.Settings.SearchArea.Height > mostBottomRightPoint.Y)
                {
                    mostBottomRightPoint.Y = convertedTask.Settings.SearchPosition.Y + convertedTask.Settings.SearchArea.Height;
                }
            }

            Tasks.MaxSearchArea = new Size(mostBottomRightPoint.X - mostTopLeftPoint.X, mostBottomRightPoint.Y - mostTopLeftPoint.Y);
            Tasks.HeightestSearchPosition = mostTopLeftPoint;
            Tasks.LowestSearchPosition = mostBottomRightPoint;
        }
    }
}
