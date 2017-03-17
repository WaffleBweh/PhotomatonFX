using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photomaton
{
    /// <summary>
    /// Interface to make new image effects
    /// </summary>
    public abstract class ImageFX : IComparable
    {
        public abstract void step(TransformedImage srcImg);
        public abstract int getMaxSteps(int w, int h);
        
        /// <summary>
        /// Returns the class name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.GetType().Name;
        }

        /// <summary>
        /// Alphanumeric comparaison for sorting imageFXs
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            return this.ToString().CompareTo(obj.ToString());
        }
    }
}
