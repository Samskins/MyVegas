using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace MyVegasBot
{
    public class Screen
    {
        private static IntPtr handle { get; set; }
        public static Bitmap fullScreen { get; set; }
        private static void ActivateWin(string processName)
        {
            var p = Process.GetProcessesByName(processName);
            handle = IntPtr.Zero;
            for (var i = 0; i < p.Length; i++)
            {
                if (p[i].MainWindowTitle != string.Empty)
                {
                    handle = p[i].MainWindowHandle;
                    DllStuff.ActivateWindow(handle);
                }
            }
        }

        public static Bitmap Shot()
        {
            ActivateWin(Form1._Form1.browser);
            if (DllStuff.IsWinVIs(handle))
            {
                Thread.Sleep(500);
                var bounds = System.Windows.Forms.Screen.GetBounds(Point.Empty);
                fullScreen = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format24bppRgb);

                using (var g = Graphics.FromImage(fullScreen))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
            }
            return fullScreen;
        }
    }
}
