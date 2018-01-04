using System;
using System.Collections.Generic;
using System.Timers;
using PixelClicker.Interfaces;
using PixelClicker.Model;

namespace PixelClicker.Core
{
    public abstract class Task : ITask
    {
        public IBasicSettings Settings { get; set; }
        public IAction Action { get; set; }

        protected static bool IsProgramClicking = false;
        protected static bool IsManualClicking = false;

        protected Task(IBasicSettings settings, IAction action, bool timer1 = false)
        {
            this.Settings = settings;
            Action = action;

            if (timer1)
            {
                var timer = new Timer(50);
                timer.Elapsed += OnTimedEvent;
                timer.Enabled = true;
            }

        }

        protected Task()
        {
            throw new NotImplementedException();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (ActiveWindow.Name.ToLower().Equals(Settings.WindowName.ToLower()) && Keyboard.IsKeyDown(Settings.Hotkey))
            {
                Action.DoAction();
            }
        }
    }
}
