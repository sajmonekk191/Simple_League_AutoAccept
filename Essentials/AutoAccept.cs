using System;
using System.Drawing;
using League_of_Legends_AutoAccept.Essentials;
using System.Threading;
using System.Windows.Forms;

namespace League_of_Legends_AutoAccept.Essentials
{
    class AutoAccept
    {
        public static IntPtr handle;
        public static string Process = "League Of Legends";
        public static Color Col = Color.FromArgb(21, 103, 101);

        public static void FindMatch()
        {
            if(Program.Activated)
            {
                try
                { 
                    Rectangle rect;
                    handle = Imports.FindWindow(null, Process);
                    Imports.GetWindowRect(handle, out rect);
                    Point Position = Screen.PixelSearch(rect, Col);
                    if (Position != new Point(0, 0))
                    {
                        Cursor.Position = new Point(Position.X + 65, Position.Y + 20);
                        const int MOUSEEVENTF_LEFTDOWN = 0x02;
                        const int MOUSEEVENTF_LEFTUP = 0x04;
                        uint X = (uint)Cursor.Position.X;
                        uint Y = (uint)Cursor.Position.Y;
                        Imports.mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    }
                    return;
                }
                catch { }
            }
        }
    }
}
