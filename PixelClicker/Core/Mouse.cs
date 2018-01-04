using System;
using System.Threading;
using System.Windows.Forms;

namespace PixelClicker.Core
{
    public class Mouse
    {
        public static void Move(int x, int y)
        {
            WindowsApi.MouseEvent(1, x, y, 0, 0);
        }
        public static void LeftClickDown()
        {
            WindowsApi.MouseEvent(0x2, 0, 0, 0, 0);
        }
        public static void LeftClickUp()
        {
            WindowsApi.MouseEvent(0x4, 0, 0, 0, 0);
        }

        public static bool IsLeftMouseDown()
        {
            return 0 != (WindowsApi.GetAsyncKeyState((int)Keys.LButton) & 0x8000);
        }
        public static bool IsKeyDown(Keys key)
        {
            return 0 != (WindowsApi.GetAsyncKeyState((int)key) & 0x8000);
        }
    }
}
