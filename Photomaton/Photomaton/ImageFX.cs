using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photomaton
{
    /// <summary>
    /// Interface to make new image effects
    /// </summary>
    public abstract class ImageFX
    {
        public abstract void step(TransformedImage srcImg);
        public abstract override string ToString();
    }
}
