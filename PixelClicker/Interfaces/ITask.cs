using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PixelClicker.Model;

namespace PixelClicker.Interfaces
{
    public interface ITask
    {
        IBasicSettings Settings { get; set; }
        IAction Action { get; set; }

    }

    public interface ITaskBitmap : ITask
    {
        new IBitmapSettings Settings { get; set; }
        void Notify(Bitmap bitmap);
        IActionProperty CheckCondition(ref LockBitmap lockBitmap);
        Bitmap Draw(ref Bitmap bitmap);
    }
}
