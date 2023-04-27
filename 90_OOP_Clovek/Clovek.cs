using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lide
{

    
    /// <summary>
    /// Reprezentuje člověka
    /// </summary>
    class Clovek
    {
        /// <summary>
        /// Celé jméno
        /// </summary>
        private string jmeno;
        /// <summary>
        /// Věk
        /// </summary>
        private int vek;
        /// <summary>
        /// Únava
        /// </summary>
        private int unava = 0;

        /// <summary>
        /// Inicializuje novou instanci
        /// </summary>
        /// <param name="jmeno">Celé jméno</param>
        /// <param name="vek">Věk</param>
        public Clovek(string jmeno, int vek)
        {
            this.jmeno = jmeno;
            this.vek = vek;
        }

        /// <summary>
        /// Spí danou dobu
        /// </summary>
        /// <param name="doba">Doba v hodinách</param>
        public void Spi(int doba)
        {
            unava -= doba * 10;
            Console.WriteLine("Spím a tím snížím únavu na " + unava);
            Console.ReadKey();
            if (unava < 0)
                unava = 0;
        }

        /// <summary>
        /// Uběhne danou vzdálenost
        /// </summary>
        /// <param name="vzdalenost">Vzdálenost v Km</param>
        public void Behej(int vzdalenost)
        {
            if (unava + vzdalenost <= 20)
            { 
                unava += vzdalenost;
                Console.WriteLine("Běžím");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Jsem příliš unavený");
        }

        /// <summary>
        /// Vrátí textovou reprezentaci člověka
        /// </summary>
        /// <returns>textová reprezentace člověka</returns>
        public override string ToString()
        {
            return string.Format("{0} ({1})", jmeno, vek);
        }
    }
}
