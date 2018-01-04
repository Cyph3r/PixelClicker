using System.Drawing;

namespace PixelClickerPrototype
{
    class SearchColor : PixelClicker.Interfaces.ISearchColor
    {
        public Color Color { get; set; }
        public int ShadeVariation { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
    }
}
