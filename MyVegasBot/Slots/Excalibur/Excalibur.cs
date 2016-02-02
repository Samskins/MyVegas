using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using MyVegasBot.Properties;

namespace MyVegasBot.Slots.Excalibur
{
    class Excalibur
    {
        public int[] coords { get; set; }
        public int[] checker { get; set; }
        public Dictionary<Bitmap, int> images { get; set; } //key = bitmap, value = times encountered successfully
        public void Start()
        {
            coords = new int[4]; Bitmap s,s1,s2;
            Calibrate calibrate = new Calibrate();
            coords = calibrate.Border();  //[0] = topX, [1] topY, [2] botY, [3] botX
            enterImages();

            while (true)
            {
                s = Screen.Shot();
                Form1._Form1.Log("Checking for possible bonus games...");
                Search(s);
                Thread.Sleep(10000); //take a rest, 10 seconds
            }
        }

        void Search(Bitmap screen)
        {
            foreach(var image in images)
            {
                checker = CompareBitmaps.GetLocation(image.Key, screen, coords[0], coords[1], coords[2], coords[3]);
                Form1._Form1.Log(string.Format("Searching for {0}...", image.Key));
                if (checker[0] != 0 || checker[1] != 0)
                {
                    Form1._Form1.Log(string.Format("Found {0}...", image.Key));
                    images = images.ToDictionary(a => a.Key, a => a.Value + 1); //+1 to the successful images
                    //ImageLogic(image.Key) // perform additional logic to find images
                    //MoveCursorAndClick(checker[0] + checker[0]/5, checker[1] + checker[1]/5); //move mouse to spot and give 20% leway on x and y
                }
            }
        }
        //add more logic like start -> 200, 500, 100?
        void enterImages()
        {
            images = new Dictionary<Bitmap, int>();
            images.Add(Resources.start, 0);
            images.Add(Resources.knightFight, 0);
            images.Add(Resources.knightDate, 0);
            images.Add(Resources.freeSpinWinnings, 0);
            images.Add(Resources.sendGift, 0);
            images.Add(Resources.checkbox, 0);
            images.Add(Resources.jackpot, 0);
        }
        /*
        void ImageLogic(string img)
        {
            switch (img)
            {
                case "start":
                    {
                        MoveCursorAndClick(checker[0] + checker[0] / 5, checker[1] + checker[1] / 5);
                        Search()
                    }
                    
                default:
                    break;
            }
        }
        */
    }
}
