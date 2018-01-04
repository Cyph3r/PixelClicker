using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PixelClicker;

namespace PixelClickerPrototype
{
    class ActionProperty : PixelClicker.Interfaces.IActionProperty
    {
        public bool DoAction { get; set; }
        public Point AimPoint = new Point(0, 0);
        public Point RelativeToScreenPoint = new Point(0, 0);
        public double Pct = 0.0;
        public DateTime Time;
        public Settings Settings;
        public HighestLowest PointsInfo;

    }
}
