using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Drawing;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using AutoHotkey.Interop;

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
        AutoHotkeyEngine ahk = new AutoHotkeyEngine();
        private readonly ResourceManager rm = new ResourceManager("MyVegasBot.Properties.Resources", Assembly.GetExecutingAssembly());

        public void Start()
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
            ts = stopWatch.Elapsed;
            screenCoords = new int[4];

            while (true)
            {
                Form1._Form1.Log("Checking for possible bonus games...");
                Search();
                Thread.Sleep(10000);
            }
        }

        private void Search()
        {
            //input screenCoords below
            ahk.ExecRaw(@"ImageSearch, OutX, OutY, 400, 200, 1200, 900, *% n % % A_WorkingDir %\images\% image %.PNG");
            //save output (OutX, OutY) to variable
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
            rmGetBitmap = (Bitmap)rm.GetObject(str);
            Form1.MoveCursorAndClick(cursorCoords[0], cursorCoords[1], rmGetBitmap.Width / 2, rmGetBitmap.Height / 2);
        }
    }
}
