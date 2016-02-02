using System;
using System.Threading;
using System.Drawing;
using MyVegasBot.Properties;

namespace MyVegasBot
{
    class Calibrate
    {
        //add for fbBorder or something, also incorporate more images, generalize the method CmpImg
        public int[] Border()
        {
            int[] temp;
            int[] coords = new int[4];
            Bitmap screen;
            Form1._Form1.Log("Attempting to calibrate, please wait...");
            Thread.Sleep(1);
            while (coords[0] == 0 && coords[1] == 0 && coords[2] == 0 && coords[3] == 0)
            {
                screen = Screen.Shot(); //Brings browser to the foreground and takes a screenshot
                temp = CompareBitmaps.GetLocation(Resources.fbBanner, screen, 0, 0, screen.Width, screen.Height); //get x-co & y-co from top border
                coords[0] = temp[0]; coords[1] = temp[1];
                coords[2] = CompareBitmaps.GetLocation(Resources.fbRight, screen, 0, 0, screen.Width, screen.Height)[0]; //get x-co from right side
                coords[3] = CompareBitmaps.GetLocation(Resources.fbBottom, screen, 0, 0, screen.Width, screen.Height)[1]; //get y-co from bottom
                Form1._Form1.Log(".");
                Thread.Sleep(5000);
            }
            Form1._Form1.Log("Calibration succeeded.");
            return coords;
        }
    }
}
