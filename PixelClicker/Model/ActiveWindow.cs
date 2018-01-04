using System;
using System.Timers;

namespace PixelClicker.Model
{
    public class ActiveWindow
    {
        public static string Name { get; set; } = "";
        public static IntPtr Handle { get; set; }
        public ActiveWindow()
        {
            var timer = new Timer(50);
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;
        }

        private static void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            object[] windowInformation = WindowsApi.GetCaption();
            if (windowInformation.Length != 2) return;

            Name = windowInformation[0].ToString();
            Handle = (IntPtr) int.Parse(windowInformation[1].ToString());
        }
    }
}
