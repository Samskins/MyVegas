using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using MyVegasBot.Properties;
using System.Resources;
using System.Reflection;

namespace MyVegasBot.Slots.Excalibur
{
    class Excalibur
    {
        public int[] coords { get; set; }
        public int[] checker { get; set; }
        public Dictionary<string, int> images { get; set; } //key = bitmap, value = times encountered successfully
        public void Start()
        {
            coords = new int[4];
            Calibrate calibrate = new Calibrate();
            coords = calibrate.Border();  //[0] = topX, [1] topY, [2] botY, [3] botX
            enterImages();

            while (true)
            {
                Form1._Form1.Log("Checking for possible bonus games...");
                Search();
                Thread.Sleep(10000); //take a rest, 10 seconds
            }
        }

        void Search()
        {
            Bitmap s = Screen.Shot();
            ResourceManager rm = new ResourceManager("MyVegasBot.Properties.Resources", Assembly.GetExecutingAssembly());
            foreach (var image in images)
            {
                checker = CompareBitmaps.GetLocation((Bitmap)rm.GetObject(image.Key), s, coords[0], coords[1], coords[2], coords[3]);
                Form1._Form1.Log(string.Format("Searching for {0}...", image.Key));
                if (checker[0] != 0 || checker[1] != 0)
                {
                    Form1._Form1.Log(string.Format("Found {0}...", image.Key));
                    images = images.ToDictionary(a => a.Key, a => a.Value + 1); //+1 to the successful images
                    ImageLogic(image.Key); // perform additional logic to find images
                    Form1._Form1.MoveCursorAndClick(checker[0] + checker[0]/5, checker[1] + checker[1]/5); //move mouse to spot and give 20% leway on x and y
                }
            }
        }
        //add more logic like start -> 200, 500, 100?
        void enterImages()
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
        
        void ImageLogic(string img)
        {
            switch (img)
            {
                case "start":
                    {
                        Form1._Form1.MoveCursorAndClick(checker[0] + checker[0] / 5, checker[1] + checker[1] / 5);
                        Search();
                    }
                    break;
                default:
                    break;
            }
        }

        /*
        SpecificSelection(image, X, Y)
{
	if (image = "start")
	{
		MouseClick, left, Add(X,40), Add(Y,15)
		Sleep 2000
		DetectImage("200", 50)
	}
	else if (image = "200")
	{
		MouseClick, left, Add(X,20), Add(Y,10)
		MouseMove, 1400, 500
	}
	else if (image = "knightFight")
	{
		Random, rand, 1, 2
		if(rand = 1){
			MouseClick, left, Add(X,50), Add(Y,100)
		}
		else{
			MouseClick, left, Add(X,250), Add(Y,100)
		}
		Sleep 7000
		DetectImage("OK", 50)
	}
	else if (image = "knightDate")
	{
		Random, rand, 1, 2
		if(rand = 1){
			MouseClick, left, Add(X,50), Add(Y,100)
		}
		else{
			MouseClick, left, Add(X,250), Add(Y,100)
		}
		Sleep 7000
		DetectImage("exit", 50)
	}
	else if (image = "jackpot")
	{
		DetectImage("checkbox", 50)
			MouseClick, left, Add(X,20), Add(Y,20)
		DetectImage("OKAY", 50)
	}
	else if (image = "freeSpinWinnings")
	{
		Sleep 2000
		DetectImage("OK", 50)
	}
	else if (image = "sendGift")
	{
		Sleep 2000
		DetectImage("exit", 50)
	}
	else if (image = "OK")
	{
		MouseClick, left, Add(X,20), Add(Y,10)
		MouseMove, 1400, 500
	}
	else if (image = "OKAY")
	{
		MouseClick, left, Add(X,20), Add(Y,10)
		MouseMove, 1400, 500
	}
	else if (image = "exit")
	{
		MouseClick, left, Add(X,10), Add(Y,10)
		MouseMove, 1400, 500
	}
	
        */
    }
}
