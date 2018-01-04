using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelClicker
{
    internal class WindowsApi
    {
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32", EntryPoint = "mouse_event", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        internal static extern void MouseEvent(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        internal static extern ushort GetAsyncKeyState(int vKey);
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        internal static extern int GetCursorPos(ref Point lpPoint);
        [DllImport("user32", EntryPoint = "GetForegroundWindow", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        internal static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll")]
        internal static extern bool PostMessage(IntPtr hWnd, uint msg, Keys key, int lParam);
        internal static object[] GetCaption()
        {
            object[] windowInformation = new object[2];
            StringBuilder caption = new System.Text.StringBuilder(256);
            IntPtr hWnd = GetForegroundWindow();
            GetWindowText(hWnd, caption, caption.Capacity);

            windowInformation[0] = caption.ToString();
            windowInformation[1] = hWnd;
            return windowInformation;
        }
    }
}
