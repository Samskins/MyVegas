using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace MyVegasBot
{
    public class ScreenCapture
    {
        private static IntPtr handle { get; set; }
        public static Bitmap fullScreen { get; set; }
        private static void ActivateWin(string processName)
        {
            Process[] p = Process.GetProcessesByName(processName);
            handle = IntPtr.Zero; //reset handle
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].MainWindowTitle != "")
                {
                    handle = p[i].MainWindowHandle;
                    DllStuff.ActivateWindow(handle);
                }
            }
        }

        public static Bitmap Shot(string browser)
        {
            ActivateWin(browser);
            if (DllStuff.IsWinVIs(handle))
            {
                Thread.Sleep(500);
                Rectangle bounds = Screen.GetBounds(Point.Empty);
                fullScreen = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format24bppRgb);

                using (Graphics g = Graphics.FromImage(fullScreen))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
            }
            return fullScreen;
        }
    }
}
