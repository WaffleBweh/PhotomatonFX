using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photomaton
{
    public class DoubleRotation : ImageFX
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

            // Go through every pixel of the image
            for (int x = 0; x < tmp.Width; x++)
            {
                for (int y = 0; y < tmp.Height; y++)
                {
                    // Get the current pixel
                    Color currentPixel = tmp.GetPixel(x, y);

                    // Get the new position of the pixels
                    int newX = 0;
                    int newY = 0;

                    if (x + 1 < tmp.Width)
                    {
                        newX = x + 1;
                    }

                    if (y + 1 < tmp.Height)
                    {
                        newY = y + 1;
                    }

                    // Paste the pixel to the correct location
                    result.SetPixel(newX, newY, currentPixel);
                }
            }

            // Set the new image
            srcImg.Image = result;
        }

        public override int getMaxSteps(int w, int h)
        {
            // The result is the lcm of width and height

            return w.lcm(h);
        }
        #endregion
    }
}
