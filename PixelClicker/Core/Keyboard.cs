using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PixelClicker.Model;

namespace PixelClicker.Core
{
    public class Keyboard
    {
        const UInt32 WM_KEYDOWN = 0x0100;
        const UInt32 WM_KEYUP = 0x0101;
        public static bool IsKeyDown(Keys key)
        {
            return 0 != (WindowsApi.GetAsyncKeyState((int)key) & 0x8000);
        }

        public static void PressKey(Keys key)
        {
            WindowsApi.PostMessage(ActiveWindow.Handle, WM_KEYDOWN, key, 0);
            WindowsApi.PostMessage(ActiveWindow.Handle, WM_KEYUP, key, 0);
        }
    }
}
