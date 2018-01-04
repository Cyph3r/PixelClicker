using System.Drawing;

namespace PixelClicker.Interfaces
{
    public interface ISearchColor
    {
        Color Color { get; set; }
        int ShadeVariation { get; set; }
        int R { get; set; }
        int G { get; set; }
        int B { get; set; }
    }
}
