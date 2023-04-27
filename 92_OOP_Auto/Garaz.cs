using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auta
{


    /// <summary>
    /// Reprezentuje garáž
    /// </summary>
    class Garaz
    {
        /// <summary>
        /// Instance auta, které je v garáži zaparkované
        /// </summary>
        private Auto auto;

        /// <summary>
        /// Vloží auto do garáže
        /// </summary>
        /// <param name="auto">Auto</param>
        public void Vloz(Auto auto)
        {
            this.auto = auto;
        }

        /// <summary>
        /// Vrátí textovou reprezentaci garáže
        /// </summary>
        /// <returns>textová reprezentace garáže</returns>
        public override string ToString()
        {
            return "V garáži je auto s SPZ: " + auto.VratSpz() + ", jehož barva je "+ auto.VratBarvu();
        }
    }
}
