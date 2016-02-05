using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Drawing;
using System.Resources;
using System.Reflection;
using System.Diagnostics;

namespace MyVegasBot.Slots.Excalibur
{
    public class Excalibur
    {
        private int[] screenCoords { get; set; }
        private int[] cursorCoords { get; set; }
        private int count { get; set; }
        private Bitmap s { get; set; }
        private Bitmap rmGetBitmap { get; set; }
        private Bitmap stuck { get; set; }
        private TimeSpan ts { get; set; }
        private Stopwatch stopWatch { get; set; }
        private Dictionary<string, int> images { get; set; }
        private readonly ResourceManager rm = new ResourceManager("MyVegasBot.Properties.Resources", Assembly.GetExecutingAssembly());
        public void Start()
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
            ts = stopWatch.Elapsed;
            screenCoords = new int[4];
            stuck = Screen.Shot();
            screenCoords = MyVegasBot.Calibrate.Border();
            enterImages();

            while (true)
            {
                Form1._Form1.Log("Checking for possible bonus games...");
                Search();
                Thread.Sleep(10000);
            }
        }

        private void Search()
        {
            s = Screen.Shot();
            foreach (var image in images.ToList())
            {
                rmGetBitmap = (Bitmap)rm.GetObject(image.Key);
                cursorCoords = CompareBitmaps.GetLocation(rmGetBitmap, s, screenCoords[0], screenCoords[1], screenCoords[2], screenCoords[3]);
                Form1._Form1.Log(string.Format("Searching for {0}...", image.Key));
                if (cursorCoords[0] != 0 || cursorCoords[1] != 0)
                {
                    count = 0;
                    Form1._Form1.Log(string.Format("Found {0}...", image.Key));
                    images[image.Key]++;
                    ImageLogic(image.Key, rmGetBitmap);
                }
                else
                {
                    if (count % 21 == 0)
                    {
                        stuck = Screen.Shot();
                    }
                    count++;
                }
            }

            if (ts.Seconds >= 60 && CompareBitmaps.isEqual(stuck, s))
            {
                stopWatch.Restart();
                Form1._Form1.Log("One minute without activity, checking for issues...");
                var s1 = Screen.Shot();
                Thread.Sleep(3000);
                var s2 = Screen.Shot();
                if (CompareBitmaps.isEqual(stuck, s1) || CompareBitmaps.isEqual(stuck, s2))
                {
                    FindAndClick("OK");
                    FindAndClick("OKAY");
                    FindAndClick("exit");
                }
            }
        }

        private void enterImages()
        {
            images = new Dictionary<string, int>();
            images.Add("start", 0);
            images.Add("knightFight", 0);
            images.Add("knightDate", 0);
            images.Add("freeSpinWinnings", 0);
            images.Add("sendGift", 0);
            images.Add("checkbox", 0);
            images.Add("jackpot", 0);
        }

        private void ImageLogic(string img, Bitmap bmp)
        {
            switch (img)
            {
                case "start":
                    Form1.MoveCursorAndClick(cursorCoords[0], cursorCoords[1], bmp.Width / 2, bmp.Height / 2);

                    FindAndClick("_" + (Form1._Form1.autoSpin));
                    break;
                case "knightFight":
                    {
                        var rnd = new Random();

                        if (rnd.Next(2) == 0)
                        {
                            Form1.MoveCursorAndClick(cursorCoords[0], cursorCoords[1], bmp.Width / 4, bmp.Height / 2);
                        }
                        else
                        {
                            Form1.MoveCursorAndClick(cursorCoords[0], cursorCoords[1], bmp.Width * (3 / 4), bmp.Height / 2);
                        }
                        Thread.Sleep(7000);
                        FindAndClick("OK");
                        break;
                    }
                case "knightDate":
                    {
                        var rnd = new Random();

                        if (rnd.Next(2) == 0)
                        {
                            Form1.MoveCursorAndClick(cursorCoords[0], cursorCoords[1], bmp.Width / 4, bmp.Height / 2); ;
                        }
                        else
                        {
                            Form1.MoveCursorAndClick(cursorCoords[0], cursorCoords[1], bmp.Width * (3 / 4), bmp.Height / 2);
                        }
                        Thread.Sleep(7000);
                        FindAndClick("exit");
                        Thread.Sleep(1000);
                        FindAndClick("OKAY");
                        break;
                    }
                case "jackpot":
                    FindAndClick("checkbox");
                    Thread.Sleep(1000);
                    FindAndClick("OKAY");
                    break;
                case "freeSpinWinnings":
                    Thread.Sleep(2000);
                    FindAndClick("OK");
                    break;
                case "sendGift":
                    Thread.Sleep(2000);
                    FindAndClick("exit");
                    break;
                default:
                    break;
            }
        }
        private void FindAndClick(string str)
        {
            s = Screen.Shot();
            rmGetBitmap = (Bitmap)rm.GetObject(str);
            cursorCoords = CompareBitmaps.GetLocation(rmGetBitmap, s, screenCoords[0], screenCoords[1], screenCoords[2], screenCoords[3]);
            Form1.MoveCursorAndClick(cursorCoords[0], cursorCoords[1], rmGetBitmap.Width / 2, rmGetBitmap.Height / 2);
        }
    }
}
