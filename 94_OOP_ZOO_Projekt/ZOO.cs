using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94_OOP_ZOO
{
    class ZOO
    {
        private List<Zvire> zvirata;

        public ZOO()
        {
            zvirata = new List<Zvire>();
        }

        public void PridatZvire()
        {
            Console.WriteLine("ZADANI NOVEHO ZVIRETE");
            Console.Write("Nazev: ");
            string nazev = Console.ReadLine();
            Console.Write("Vek: ");
            int vek = Int32.Parse(Console.ReadLine());
            Console.Write("Vaha: ");
            double vaha = Double.Parse(Console.ReadLine());

            Zvire zvire = new Zvire(nazev, vek, vaha);
            zvirata.Add(zvire);
        }

        public void VypisZvirat()
        {
            Console.WriteLine("VYPIS ZVIRAT");
            foreach (Zvire zvire in zvirata)
            {
                zvire.VypisPopis();
            }
        }
    }
}
