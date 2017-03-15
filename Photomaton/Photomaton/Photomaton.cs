using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the class name as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.GetType().Name;
        }

        public override int getMaxSteps()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
