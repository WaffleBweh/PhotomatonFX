using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photomaton
{
    public class BinaryMixture : ImageFX
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
            // Make a temporary copy of our image as a bitmap
            Bitmap tmp = (Bitmap)srcImg.Image.Clone();
            // The image we will actually draw on
            Bitmap result = new Bitmap(srcImg.Image.Width, srcImg.Image.Height);

            // Create an offset value
            int halfWidth = tmp.Width / 2;

            // Get the coordinates of each of the four points to draw the image
            Point topLeft = new Point(0, 0);
            Point topRight = new Point(halfWidth, 0);
            Point botLeft = new Point(0, halfWidth);
            Point botRight = new Point(halfWidth, halfWidth);

            // Go through every pixel of the image
            for (int x = 0; x < tmp.Width; x++)
            {
                for (int y = 0; y < tmp.Height; y++)
                {
                    // Get the current pixel
                    Color currentPixel = tmp.GetPixel(x, y);
                    // Get the current offset values
                    int offsetX = x / 2;
                    int offsetY = y / 2;

                    // Paste the pixel to the correct location

                    // Check if the x coordinate is even or odd
                    if (x % 2 == 0)
                    {
                        // Even
                        // Check if the y coordinate is even or odd
                        if (y % 2 == 0)
                        {
                            // Even
                            result.SetPixel(topLeft.X + offsetX, topLeft.Y + offsetY, currentPixel);
                        }
                        else
                        {
                            // Odd
                            result.SetPixel(topRight.X + offsetX, topRight.Y + offsetY, currentPixel);
                        }
                    }
                    else
                    {
                        // Odd
                        // Check if the y coordinate is even or odd
                        if (y % 2 == 0)
                        {
                            // Even
                            result.SetPixel(botLeft.X + offsetX, botLeft.Y + offsetY, currentPixel);
                        }
                        else
                        {
                            // Odd
                            result.SetPixel(botRight.X + offsetX, botRight.Y + offsetY, currentPixel);
                        }
                    }

                }
            }

            // Set the new image
            srcImg.Image = result;
        }


        public override int getMaxSteps(int w, int h)
        {
            // The result is the corresponding power of two of the width times the height
            int result = (w * h).PowerOfTwo();
            return result;
        }
        #endregion
    }
}
