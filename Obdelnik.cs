using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84_OOP_05_Obdelnik
{
    internal class Obdelnik
    {
        public double StranaA;
        public double StranaB;

        public double Obvod()
        {
            return 2 * (StranaA + StranaB);
        }

        public double Obsah()
        {
            return StranaA * StranaB;
        }
    }
}
