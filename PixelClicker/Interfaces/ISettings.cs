using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PixelClicker.Types;

namespace PixelClicker.Interfaces
{
    public interface IBasicSettings
    {
        string Name { get; set; }
        Keys Hotkey { get; set; }
        string WindowName { get; set; }
    }
    public interface IBitmapSettings : IBasicSettings
    {
        List<ISearchColor> SearchColors { get; set; }
        int LastFps { get; set; }
        Size SearchArea { get; set; }
        Point SearchPosition { get; set; }
        SearchMethod SearchMethod { get; set; }
        bool Debug { get; set; }
        bool Draw { get; set; }
    }
}
