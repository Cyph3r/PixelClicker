using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CEasy;
using PixelClicker;
using PixelClicker.Model;
using PixelClicker.Types;

namespace PixelClickerPrototype
{
    class Program
    {
        private static readonly DrawForm DrawForm1 = new DrawForm();
        public static Settings Settings;
        private static HealthBar _task;
        private static Action _action;
        private static int _adjustMode = 0;

        private static readonly int MaxSearchMethods =
            (int) Enum.GetValues(typeof(SearchMethod)).Cast<SearchMethod>().Max() + 1;

        private static DateTime? _labelTimeOut;
        private static DateTime? _modeChangedTimeOut;
        private static DateTime? _settingTimeOut;
        private static DateTime? _hotKeyTimeOut;
        private static DateTime? _drawTimeOut;

        [STAThread]
        static void Main(string[] args)
        {
            ActiveWindow activeWindow = new ActiveWindow();

            Settings = Settings.Instance();
            _action = new Action();
            _task = new HealthBar(Settings, _action);
            License.CheckLicense();

            Tasks.Items.Add(_task);

            _task.Start();

            if (Settings.Draw)
            {
                DrawForm1.Show();
            }

            while (!PixelClicker.Core.Keyboard.IsKeyDown(Keys.F12))
            {
                Thread.Sleep(1);
                Draw();

                if (Settings.Draw)
                {
                    SwitchAdjustMode();
                    AdjustSettings();

                    DrawForm1.labelFPS.Text = Settings.LastFps.ToString();

                    if (_labelTimeOut?.Subtract(DateTime.Now).Seconds <= -3)
                    {
                        License.CheckLicense();
                        DrawForm1.labelSettingChanged.Text = "";
                        DrawForm1.panel5.Visible = false;
                        _labelTimeOut = null;
                        _adjustMode = 0;
                    }

                    DrawForm1.Location = Settings.SearchPosition;
                    DrawForm1.Size = Settings.SearchArea;
                    DrawForm1.Invalidate();

                    Application.DoEvents();
                }
            }

            _task.Cancel();
        }

        static void SwitchAdjustMode()
        {
            if (_modeChangedTimeOut?.Subtract(DateTime.Now).Milliseconds <= -300)
                _modeChangedTimeOut = null;
            else if (_modeChangedTimeOut != null) return;

            if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.F11))
            {
                _adjustMode += 1;
                _adjustMode = _adjustMode%7;

                switch (_adjustMode)
                {
                    case 0:
                        DrawForm1.labelSettingChanged.Text = "M: Offsets";
                        break;
                    case 1:
                        DrawForm1.labelSettingChanged.Text = "M: Sensitivity";
                        break;
                    case 2:
                        DrawForm1.labelSettingChanged.Text = "M: Position";
                        break;
                    case 3:
                        DrawForm1.labelSettingChanged.Text = "M: Area";
                        break;
                    case 4:
                        DrawForm1.labelSettingChanged.Text = "M: Search Method";
                        break;
                    case 5:
                        _hotKeyTimeOut = DateTime.Now;
                        DrawForm1.labelSettingChanged.Text = "M: Hotkey (Press Any Key)";
                        break;
                }

                DrawForm1.panel5.Visible = true;
                _modeChangedTimeOut = DateTime.Now;
                _labelTimeOut = DateTime.Now;
            }
        }

        static void AdjustSettings()
        {
            if (_settingTimeOut?.Subtract(DateTime.Now).Milliseconds <= -100)
                _settingTimeOut = null;
            else if (_settingTimeOut != null) return;

            bool adjusted = false;

            switch (_adjustMode)
            {
                case 0:
                    adjusted = AdjustOffsets();
                    break;
                case 1:
                    adjusted = AdjustSensitivity();
                    break;
                case 2:
                    adjusted = AdjustPosition();
                    break;
                case 3:
                    adjusted = AdjustSearchArea();
                    break;
                case 4:
                    adjusted = AdjustSearchMethod();
                    break;
                case 5:
                    adjusted = SetHotkey();
                    break;
            }

            if (adjusted)
            {
                Settings.SaveSetting();
                _labelTimeOut = DateTime.Now;
                _settingTimeOut = DateTime.Now;
                DrawForm1.panel5.Visible = true;
            }

        }

        static bool AdjustOffsets()
        {
            bool changed = false;

            if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Up))
            {
                Settings.YOffset -= 1;
                changed = true;
            }
            else if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Down))
            {
                Settings.YOffset += 1;
                changed = true;
            }
            else if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Right))
            {
                Settings.XOffset += 1;
                changed = true;
            }
            else if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Left))
            {
                Settings.XOffset -= 1;
                changed = true;
            }

            if (changed)
            {
                DrawForm1.labelSettingChanged.Text = $"Offset: X={Settings.XOffset},Y={Settings.YOffset}";
            }

            return changed;
        }

        static bool AdjustSensitivity()
        {
            bool changed = false;

            if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Up))
            {
                Settings.Sensitivity += 1;
                changed = true;
            }
            else if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Down))
            {
                Settings.Sensitivity -= 1;
                changed = true;
            }

            if (changed)
            {
                DrawForm1.labelSettingChanged.Text = "Sensitivity: " + Settings.Sensitivity.ToString();
            }

            return changed;
        }

        static bool AdjustPosition()
        {
            bool changed = false;
            Point newPoint = Point.Empty;
            if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Up))
            {
                newPoint = new Point(Settings.SearchPosition.X, Settings.SearchPosition.Y - 10);
                changed = true;
            }
            else if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Down))
            {
                newPoint = new Point(Settings.SearchPosition.X, Settings.SearchPosition.Y + 10);
                changed = true;
            }
            else if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Right))
            {
                newPoint = new Point(Settings.SearchPosition.X + 10, Settings.SearchPosition.Y);
                changed = true;
            }
            else if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Left))
            {
                newPoint = new Point(Settings.SearchPosition.X - 10, Settings.SearchPosition.Y);
                changed = true;
            }

            if (changed)
            {
                Settings.SearchPosition = newPoint;
                DrawForm1.labelSettingChanged.Text = "Position: " + newPoint.ToString();
            }
            return changed;
        }

        static bool AdjustSearchArea()
        {
            bool changed = false;

            if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Up))
            {
                Settings.SearchArea = new Size(Settings.SearchArea.Width, Settings.SearchArea.Height + 10);
                changed = true;
            }
            else if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Down))
            {
                Settings.SearchArea = new Size(Settings.SearchArea.Width, Settings.SearchArea.Height - 10);
                changed = true;
            }
            else if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Right))
            {
                Settings.SearchArea = new Size(Settings.SearchArea.Width + 10, Settings.SearchArea.Height);
                changed = true;
            }
            else if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Left))
            {
                Settings.SearchArea = new Size(Settings.SearchArea.Width - 10, Settings.SearchArea.Height);
                changed = true;
            }

            if (changed)
            {
                DrawForm1.labelSettingChanged.Text = "Area: " + Settings.SearchArea.ToString();
            }
            return changed;
        }

        static bool AdjustSearchMethod()
        {
            bool changed = false;
            int currentSearchMethod = (int) Settings.SearchMethod;

            if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Up))
            {
                currentSearchMethod++;
                Settings.SearchMethod = (SearchMethod) ((int) currentSearchMethod%MaxSearchMethods);
                changed = true;
            }
            else if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Down))
            {
                currentSearchMethod--;

                if (currentSearchMethod < 0)
                    Settings.SearchMethod = (SearchMethod) MaxSearchMethods - 1;
                else
                    Settings.SearchMethod = (SearchMethod) ((int) currentSearchMethod%MaxSearchMethods);

                changed = true;
            }


            if (changed)
            {
                if (Settings.SearchMethod == SearchMethod.MiddleOfScreen) Settings.SearchPosition = Point.Empty;
                DrawForm1.labelSettingChanged.Text = "Method: " + Settings.SearchMethod.ToString();
            }
            return changed;
        }

        static bool SetHotkey()
        {
            if (_hotKeyTimeOut?.Subtract(DateTime.Now).Milliseconds <= -300)
                _hotKeyTimeOut = null;
            else if (_hotKeyTimeOut != null) return false;

            bool changed = false;
            foreach (var key in EnumUtil.GetValues<Keys>())
            {
                if (key == Keys.F11 || key == Keys.Up || key == Keys.Down || key == Keys.Left || key == Keys.Right)
                    continue;

                if (PixelClicker.Core.Keyboard.IsKeyDown(key))
                {
                    Settings.Hotkey = key;
                    _adjustMode = 0;
                    changed = true;
                }
            }

            if (changed)
            {
                DrawForm1.labelSettingChanged.Text = "Hotkey: " + Settings.Hotkey.ToString();
            }

            return changed;
        }

        static void Draw()
        {
            if (_drawTimeOut?.Subtract(DateTime.Now).Milliseconds <= -300)
                _drawTimeOut = null;
            else if (_drawTimeOut != null) return;

            if (PixelClicker.Core.Keyboard.IsKeyDown(Keys.Insert))
            {
                Settings.Draw = !Settings.Draw;
                DrawForm1.Visible = Settings.Draw;
                _drawTimeOut = DateTime.Now;
                Settings.SaveSetting();
            }
        }

        public static class EnumUtil
        {
            public static IEnumerable<T> GetValues<T>()
            {
                return Enum.GetValues(typeof(T)).Cast<T>();
            }
        }
    }
}
