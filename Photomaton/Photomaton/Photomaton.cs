using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photomaton
{
    public class Photomaton : ImageFX
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

            // Go through every second pixel of the image
            for (int x = 0; x < tmp.Width; x += 2)
            {
                for (int y = 0; y < tmp.Height; y += 2)
                {
                    // Get the four current pixels
                    Color topLeftPixel = tmp.GetPixel(x, y);
                    Color topRightPixel = tmp.GetPixel(x + 1, y);
                    Color botLeftPixel = tmp.GetPixel(x, y + 1);
                    Color botRightPixel = tmp.GetPixel(x + 1, y + 1);

                    // Get the current offset values (half the width and height)
                    int offsetX = x / 2;
                    int offsetY = y / 2;

                    // Paste the pixels to the correct location
                    result.SetPixel(topLeft.X + offsetX, topLeft.Y + offsetY, topLeftPixel);
                    result.SetPixel(topRight.X + offsetX, topRight.Y + offsetY, topRightPixel);
                    result.SetPixel(botLeft.X + offsetX, botLeft.Y + offsetY, botLeftPixel);
                    result.SetPixel(botRight.X + offsetX, botRight.Y + offsetY, botRightPixel);
                }
            }

            // Set the new image
            srcImg.Image = result;
        }


        public override int getMaxSteps(int w, int h)
        {
            int newW = w.PowerOfTwo();
            int newH = h.PowerOfTwo();

            return newW.lcm(newH);
        }
        #endregion
    }
}
