using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photomaton
{
    public class Baker : ImageFX
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
            Bitmap result = new Bitmap(srcImg.Image.Width * 2, srcImg.Image.Height);

            // Go through every pixel of the image
            for (int x = 0; x < tmp.Width; x++)
            {
                for (int y = 0; y < tmp.Height; y++)
                {
                    Color currentPixel = tmp.GetPixel(x, y);

                    // Get the pixels (https://en.wikipedia.org/wiki/Baker%27s_map)
                    if (x >= 0 && x <= (tmp.Width / 2))
                    {
                        result.SetPixel(2*x, y/2, currentPixel);
                    }
                    else
                    {
                        result.SetPixel((2*x)-1, (y+1)/2, currentPixel);
                    }
                }
            }

            // Set the new image
            srcImg.Image = result;
        }



        public override int getMaxSteps(int w, int h)
        {
            // The result is the power of two of w + the power of two of h + 1
            int newW = w.PowerOfTwo();
            int newH = h.PowerOfTwo();

            return newW + newH + 1;
        }
        #endregion
    }
}
