using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace League_of_Legends_AutoAccept.Essentials
{
    class Imports
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        public static int MOUSEEVENTF_LEFTDOWN = 0x02;
        public static int MOUSEEVENTF_LEFTUP = 0x04;
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, out Rectangle IpRect);
    }
}
