using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PixelClicker;
using PixelClicker.Core;
using PixelClicker.Interfaces;
using PixelClicker.Types;

namespace PixelClickerPrototype
{
    public class Settings : IBitmapSettings
    {
        private static Settings _instance;

        private Settings()
        {
        }

        public static Settings Instance()
        {
            if (_instance != null)
                return _instance;
            else
            {
                if (File.Exists("SimplePixelClicker.json"))
                    _instance = LoadSetting();
                else
                {
                    _instance = new Settings();
                    _instance.SaveSetting();
                }

                return _instance;
            }
        }

        public void SaveSetting()
        {
            string settings = JsonConvert.SerializeObject(this, Formatting.Indented);

            using (StreamWriter sw = new StreamWriter("SimplePixelClicker.json", false))
            {
                sw.WriteLine(settings);
            }
        }

        private static Settings LoadSetting()
        {
            using (StreamReader sr = new StreamReader("SimplePixelClicker.json"))
            {

                return JsonConvert.DeserializeObject<Settings>(sr.ReadToEnd());
            }
        }


        [JsonIgnore]
        public Point CurrentAimPos = new Point(0, 0);

        [JsonIgnore]
        public HighestLowest PointsInfo;
        public string Name { get; set; } = "test";
        public Keys Hotkey { get; set; } = Keys.LButton;
        public string WindowName { get; set; } = "overwatch";
        public List<ISearchColor> SearchColors { get; set; }
        [JsonIgnore]
        public int LastFps { get; set; }
        public int MaximumHealthBarHeight = 3;
        [JsonIgnore]
        public int WidthOffset = 50;
        [JsonIgnore]
        public int HeightOffset = 125;

        public int YOffset = 60;
        public int XOffset = 30;
        public int Sensitivity = 15;
        private Size _searchArea = new Size(100, 250);
        public Size SearchArea
        {
            get { return _searchArea; }
            set
            {
                _searchArea = value;

                WidthOffset = value.Width / 2;
                HeightOffset = value.Height / 2;

                if (SearchMethod == SearchMethod.MiddleOfScreen)
                    _searchPos = new Point(SystemInformation.VirtualScreen.Width / 2 - WidthOffset, (int)(SystemInformation.VirtualScreen.Height / 2 - HeightOffset * 1.75));
            }
        }
        private Point _searchPos;
        public Point SearchPosition
        {
            get { return _searchPos; }
            set
            {
                switch (SearchMethod)
                {
                    case SearchMethod.AnyWhere:
                        _searchPos = new Point(value.X, value.Y);
                        break;
                    case SearchMethod.MiddleOfScreen:
                        _searchPos = new Point(SystemInformation.VirtualScreen.Width / 2 - WidthOffset, (int)(SystemInformation.VirtualScreen.Height / 2 - HeightOffset * 1.75));
                        break;
                    case SearchMethod.CursorPosition:
                        _searchPos = new Point(value.X - WidthOffset, (int)(value.Y - HeightOffset * 1.75));
                        break;
                }
            }
        }

        public SearchMethod SearchMethod { get; set; } = SearchMethod.CursorPosition;
        public bool Debug { get; set; } = false;
        public bool Draw { get; set; } = true;
    }
}
