﻿using System;
using System.Drawing;

namespace MyVegasBot
{
    class CompareBitmaps
    {
      /// <summary>
      /// Compares two images and has paramters for width and length start and end coordinates.
      /// </summary>
      /// <param name="smallImg"></param>
      /// <param name="bigImg"></param>
      /// <param name="topX"></param>
      /// <param name="topY"></param>
      /// <param name="botX"></param>
      /// <param name="botY"></param>
        public static int[] GetLocation(Bitmap smallImg, Bitmap bigImg, int topX, int topY, int botX, int botY)
        {
            int[] result = new int[2];
            int max = 0, foundX = 0, foundY = 0, maxX = 0, maxY = 0, c = 0, d;
            LockBitmap lockSmall = new LockBitmap(smallImg);
            LockBitmap lockBig = new LockBitmap(bigImg);
            lockSmall.LockBits(); lockBig.LockBits();  //lock the bits
            for (int y = topY; y < (botY - lockSmall.Height) - 1; y++)  //borders only the area neccesary
            {
                d = 0; //reset small image search to the first x value
                for (int x = topX; x < (botX - lockSmall.Width) - 1; x++)  //borders only the area neccesary
                {
                    if(lockBig.GetPixel(x, y) != lockSmall.GetPixel(d, c))
                    {
                        d = 0;
                        continue;
                    }
                    else
                    {
                        if(d == 0) //max candidates
                        {
                            foundX = x;
                            foundY = y;
                        }
                        
                        if(d > max)
                        {
                            max = d;
                            maxX = foundX;
                            maxY = foundY;
                        }

                        if (d == lockSmall.Width)  //resets search to beginning of next line
                        {
                            c++;
                            topX = maxX;
                            break;
                        } 
                        else

                        d++;
                    }
                }
            }

            if(maxX == 0 && maxY == 0)
            {
                
            }
            lockSmall.UnlockBits(); lockBig.UnlockBits();
            result[0] = maxX; result[1] = maxY;
            return result;
        }

        public static bool isEqual(Bitmap image1, Bitmap image2)
        {
            bool equal = true;
            LockBitmap lock1 = new LockBitmap(image1);
            LockBitmap lock2 = new LockBitmap(image2);
            lock1.LockBits(); lock2.LockBits();  //lock the bits
            for (int y = 0; y < lock1.Height; y++)  //borders only the area neccesary
            {
                if (!equal) { break; }
                for (int x = 0; x < lock1.Width; x++)  //borders only the area neccesary
                {
                    if (lock2.GetPixel(x, y) != lock1.GetPixel(x, y))
                    {
                        equal = false;
                        break;
                    }
                }
            }
            lock1.UnlockBits(); lock2.UnlockBits();
            return equal;
        }
    }
}