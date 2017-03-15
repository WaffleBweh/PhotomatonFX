using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photomaton
{
    public class TransformedImage
    {
        #region fields
        private Image _image;           // The source image
        private ImageFX _imageHelper;  // The effect applied to the image
        #endregion

        #region properties
        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }

        internal ImageFX ImageHelper
        {
            get { return _imageHelper; }
            set { _imageHelper = value; }
        }
        #endregion

        #region constructors
        /// <summary>
        /// Designated constructor
        /// </summary>
        /// <param name="img">The source image</param>
        /// <param name="fx">The effect to apply to the image</param>
        public TransformedImage(Image img, ImageFX fx)
        {
            this.Image = img;
            this.ImageHelper = fx;
        }
        #endregion

        #region methods
        /// <summary>
        /// Steps using the current helper
        /// </summary>
        public void step()
        {
            this.ImageHelper.step(this);
        }
        #endregion
    }
}
