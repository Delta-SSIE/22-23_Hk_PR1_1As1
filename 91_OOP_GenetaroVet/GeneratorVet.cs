using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorVet
{


    /// <summary>
    /// Generátor náhodných vět
    /// </summary>
    class GeneratorVet
    {
        /// <summary>
        /// Slovní zásoba přívlastků
        /// </summary>
        private string[] privlastky = {"modrý", "velký", "hubený", "nejlepší", "automatizovaný"};
        /// <summary>
        /// Slovní zásoba předmětů
        /// </summary>
        private string[] podmety = {"jednorožec", "programátor", "manažer", "hroch", "T-rex"};
        /// <summary>
        /// Slovní zásoba příslovcí
        /// </summary>
        private string[] prislovce = {"rychle", "s oblibou", "hodně", "málo", "se zpožděním"};
        /// <summary>
        /// Slovní zásoba sloves
        /// </summary>
        private string[] slovesa = {"spal", "ležel", "vařil", "uklízel", "derivoval"};
        /// <summary>
        /// Slovní zásoba příslovečných určení místa
        /// </summary>
        private string[] pum = {"pod stolem", "v lese", "u babičky", "v práci", "na stole"};
        /// <summary>
        /// Generátor náhodných čísel
        /// </summary>
        private Random generator = new Random();

        /// <summary>
        /// Vrátí náhodné slovo z pole
        /// </summary>
        /// <param name="pole">Vstupní pole</param>
        /// <returns>Náhodné slovo</returns>
        private string NahodneSlovo(string[] pole)
        {
            int index = generator.Next(pole.Length);
            string slovo = pole[index];
            return slovo;
        }

        /// <summary>
        /// Vrátí náhodnou větu
        /// </summary>
        /// <returns>Náhodná věta</returns>
        public string Generuj()
        {
            return string.Format("{0} {1} {2} {3} {4}", 
                NahodneSlovo(privlastky), 
                NahodneSlovo(podmety),
                NahodneSlovo(prislovce), 
                NahodneSlovo(slovesa), 
                NahodneSlovo(pum)
            );
        }
    }
}
