using System.Threading;
using System.Drawing;
using MyVegasBot.Properties;

namespace MyVegasBot
{
    public class Calibrate
    {
        public static int[] Border()
        {
            int[] temp1, temp2;
            var coords = new int[4];
            Bitmap screen;
            Form1._Form1.Log("/Attempting to calibrate, please wait...");
            Thread.Sleep(1);
            while (coords[0] == 0 || coords[1] == 0 || coords[2] == 0 || coords[3] == 0)
            {
                screen = Screen.Shot();
                temp1 = CompareBitmaps.GetLocation(Resources.topBorder, screen, 0, 0, screen.Width, screen.Height);
                temp2 = CompareBitmaps.GetLocation(Resources.botBorder, screen, 0, 0, screen.Width, screen.Height);
                coords[0] = temp1[0];
                coords[1] = temp1[1];
                coords[2] = temp2[0] + Resources.botBorder.Width;
                coords[3] = temp2[1] + Resources.botBorder.Height;
                Form1._Form1.Log("/.");
                Thread.Sleep(5000);
            }
            Form1._Form1.Log("Calibration succeeded.");
            Form1._Form1.Log(string.Format("Border found at {0},{1} X {2},{3}",coords[0], coords[1], coords[2], coords[3]));
            return coords;
        }
    }
}
