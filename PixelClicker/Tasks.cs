using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PixelClicker.Interfaces;

namespace PixelClicker
{
    public class Tasks
    {
        internal static Point HeightestSearchPosition { get; set; }
        internal static Point LowestSearchPosition { get; set; }
        internal static Size MaxSearchArea { get; set; }

        public static List<ITask> Items = new List<ITask> {};
    }
}
