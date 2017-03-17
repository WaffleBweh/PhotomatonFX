using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photomaton
{
    public class Spiral : ImageFX
    {
        #region fields
        #endregion

        #region properties
        #endregion

        #region constructors
        #endregion

        #region methods
        public override void step(TransformedImage srcImg)
        {
            // Make a copy of our image as a bitmap
            Bitmap tmp = (Bitmap)srcImg.Image.Clone();

            // Find the center of the image
            int centerX = tmp.Width / 2;
            int centerY = tmp.Height / 2;

            int i = 0;
            int amount = 0;
            int currentX = centerX;
            int currentY = centerY;
            bool lastMovedInX = false; // Check if we moved in "x" last time

            // Start at the center and do a spiral pattern
            // We start from the center and follow this pattern :
            // x+1 -> y+1 -> x-2 -> y-2 -> x+3 -> y+3 -> etc...
            while ((currentX < tmp.Width - 1) && (currentY < tmp.Height - 1))
            {
                
                if ((i % 2) == 0)
                {
                    amount++;
                }

                i++;

                // Store the last positions
                int oldX = currentX;
                int oldY = currentY;

                // If our counter is even, we substract, else we add
                if ((amount % 2) == 0)
                {
                    if (lastMovedInX)
                    {
                        currentY -= amount;
                    }
                    else
                    {
                        currentX -= amount;
                    }

                    int rememberedX;
                    int rememberedY;
                    for (int x = oldX; x >= currentX; x--)
                    {
                        for (int y = oldY; y >= currentY; y--)
                        {
                            rememberedX = x;
                            rememberedY = y;

                            Color currentPixel = tmp.GetPixel(x, y);
                            tmp.SetPixel(rememberedX, rememberedY, currentPixel);
                        }
                    }

                }
                else
                {
                    if (lastMovedInX)
                    {
                        currentY += amount;
                    }
                    else
                    {
                        currentX += amount;
                    }


                    int rememberedX;
                    int rememberedY;
                    for (int x = oldX; x <= currentX; x++)
                    {
                        for (int y = oldY; y <= currentY; y++)
                        {
                            rememberedX = x;
                            rememberedY = y;

                            Color currentPixel = tmp.GetPixel(x, y);
                            tmp.SetPixel(rememberedX, rememberedY, currentPixel);
                        }
                    }
                }

                // Invert our switch 
                lastMovedInX = !lastMovedInX;
            }

            // Set the new image
            srcImg.Image = tmp;
        }

        public override int getMaxSteps(int w, int h)
        {
            // The result is the width times the height
            return w*h;
        }
        #endregion
    }
}
