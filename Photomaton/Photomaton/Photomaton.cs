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
            Bitmap tmp = new Bitmap(srcImg.Image);
            // The image we will actually draw on
            Bitmap result = new Bitmap(srcImg.Image.Width, srcImg.Image.Height);

            // Create an offset value
            int offset = tmp.Width / 2;

            // Get the coordinates of each of the four points to draw the image
            Point topLeft = new Point(0, 0);
            Point topRight = new Point(offset, 0);
            Point botLeft = new Point(0, offset);
            Point botRight = new Point(offset, offset);

            // Go through every second pixel of the image (divide the size by two)
            for (int x = 0; x < tmp.Width; x += 2)
            {
                for (int y = 0; y < tmp.Height; y += 2)
                {
                    // Get the current offset values
                    int offsetX = x / 2;
                    int offsetY = y / 2;

                    // Get the current pixel
                    Color currentPixel = tmp.GetPixel(x, y);

                    // Paste it to the correct locations on our result image
                    result.SetPixel(topLeft.X + offsetX, topLeft.Y + offsetY, currentPixel);
                    result.SetPixel(topRight.X + offsetX, topRight.Y + offsetY, currentPixel);
                    result.SetPixel(botLeft.X + offsetX, botLeft.Y + offsetY, currentPixel);
                    result.SetPixel(botRight.X + offsetX, botRight.Y + offsetY, currentPixel);
                }
            }

            // Set the new image
            srcImg.Image = result;
        }

        /// <summary>
        /// Returns the class name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.GetType().Name;
        }

        public override int getMaxSteps(int w, int h)
        {
            int wPow = w.PowerOfTwo();
            int hPow = h.PowerOfTwo();

            return wPow.lcm(hPow);
        }
        #endregion
    }
}
