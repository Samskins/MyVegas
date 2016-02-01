using System;
using System.Threading;
using System.Drawing;
using MyVegasBot.Properties;

namespace MyVegasBot
{
    class Calibrate : Form1
    {
        //add for fbBorder or something, also incorporate more images, generalize the method CmpImg
        public int[] Border()
        {
            int[] coords = new int[4];
            Bitmap screen;
            Log(string.Format("Attempting to calibrate on {0}, please wait...", Thread.CurrentThread.IsBackground));
            Thread.Sleep(1);
            while (coords[0] == 0 && coords[1] == 0 && coords[2] == 0 && coords[3] == 0)
            {
                screen = ScreenCapture.Shot(browser); //Brings browser to the foreground and takes a screenshot
                coords[0] = CompareBitmaps.GetLocation(Resources.fbBanner, screen, 0, 0, screen.Width, screen.Height)[0]; //get x-co from top border
                coords[1] = CompareBitmaps.GetLocation(Resources.fbBanner, screen, 0, 0, screen.Width, screen.Height)[1]; //get y-co from top border
                coords[2] = CompareBitmaps.GetLocation(Resources.fbRight, screen, 0, 0, screen.Width, screen.Height)[0]; //get x-co from right side
                coords[3] = CompareBitmaps.GetLocation(Resources.fbBottom, screen, 0, 0, screen.Width, screen.Height)[1]; //get y-co from bottom
                Log("failed, reattempting...");
                Thread.Sleep(5000);
            }
            Log("Calibration succeeded.");
            return coords;
        }
    }
}
