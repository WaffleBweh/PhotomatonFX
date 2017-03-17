using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photomaton
{
    public class InX : ImageFX
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

                    // Calculate the new positions
                    // If x is even, we add +2 to it, same for y.
                    int newX = (x % 2 == 0) ? x + 2 : x - 2;
                    int newY = (y % 2 == 0) ? y + 2 : y - 2;

                    // Avoid underflow or overflow
                    newX = newX.LimitToRange(0, tmp.Width  - 1); // width is -1 to because we start from 0
                    newY = newY.LimitToRange(0, tmp.Height - 1); // height is -1 to because we start from 0

                    // Paste the pixel to the correct location
                    result.SetPixel(newX, newY, currentPixel);
                }
            }

            // Set the new image
            srcImg.Image = result;
        }

        public override int getMaxSteps(int w, int h)
        {
            // The result is LCM of (w / 2) and (h / 2)
            int newW = w / 2;
            int newH = h / 2;

            return newW.lcm(newH);
        }
        #endregion
    }
}
