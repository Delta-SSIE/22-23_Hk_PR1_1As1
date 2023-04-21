using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _888_Krušnice_get_set
{
    internal class Kruznice
    {
        //datová položka
        private double _polomer = 0;

        //setter
        public void NastavPolomer(double hodnota)
        {
            //ověříme, že je v pořádku
            if (hodnota < 0)
                throw new ArgumentOutOfRangeException();

            //vím, že je OK
            _polomer = hodnota;
        }

        //getter
        public double VratPolomer()
        {
            return _polomer;
        }

        //metoda
        public double Obvod()
        {
            return 2 * Math.PI * _polomer;
        }

        public double Obsah()
        {
            return Math.PI * _polomer * _polomer;
        }
    }
}
