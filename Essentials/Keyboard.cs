using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace League_of_Legends_AutoAccept.Essentials
{
    class Keyboard
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);
    }
}
