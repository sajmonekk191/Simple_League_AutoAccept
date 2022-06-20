using Hazdryx.Drawing;
using System.Drawing;
using System.Drawing.Imaging;

namespace League_of_Legends_AutoAccept
{
    class Screen
    {
        public static Point PixelSearch(Rectangle rect, Color PixelColor)
        {
            int searchvalue = PixelColor.ToArgb();
            unsafe
            {
                Bitmap BMP = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppRgb);
                Graphics GFX = Graphics.FromImage(BMP);
                GFX.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
                using (FastBitmap bitmap = new FastBitmap(BMP))
                {
                    for (int i = 0; i < bitmap.Length; i++)
                    {
                        if (searchvalue == bitmap.GetI(i))
                        {
                            int x = i % bitmap.Width;
                            int y = i / bitmap.Width;
                            return new Point(x + rect.X, y + rect.Y);
                        }
                    }
                }
            }
            return new Point(0, 0);
        }
    }
}
