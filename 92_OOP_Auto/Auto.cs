using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auta
{


    /// <summary>
    /// Reprezentuje auto
    /// </summary>
    class Auto
    {
        /// <summary>
        /// SPZ
        /// </summary>
        private string spz;
        /// <summary>
        /// Barva
        /// </summary>
        private string barva;

        /// <summary>
        /// Inicializuje novou instanci
        /// </summary>
        /// <param name="spz">SPZ</param>
        /// <param name="barva">Barva</param>
        public Auto(string spz, string barva)
        {
            this.spz = spz;
            this.barva = barva;
        }

        /// <summary>
        /// Vrátí SPZ auta
        /// </summary>
        /// <returns>SPZ auta</returns>
        public string VratSpz()
        {
            return spz;
        }

        public string VratBarvu()
        {
            return barva;
        }
        /// <summary>
        /// Zaparkuje auto do garáže
        /// </summary>
        /// <param name="garaz">Garáž</param>
        public void Zaparkuj(Garaz garaz)
        {
            garaz.Vloz(this);
        }
    }
}
