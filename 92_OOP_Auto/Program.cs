using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auta
{
    class Program
    {


        static void Main(string[] args)
        {
            Garaz garaz = new Garaz();
            Auto skoda = new Auto("123ABC", "modrá");
            skoda.Zaparkuj(garaz);
            Console.WriteLine(garaz);
            Console.ReadKey();
        }
    }
}
