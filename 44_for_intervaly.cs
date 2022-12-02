using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_for_intervaly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte levou mez 1. intervalu: ");
            int levaMez1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte pravou mez 1. intervalu: ");
            int pravaMez1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte levou mez 2. intervalu: ");
            int levaMez2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte pravou mez 2. intervalu: ");
            int pravaMez2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dvojice čísel, jejichž součet leží v některém z intervalů:");
            Console.WriteLine("(1. číslo je z prvního intervalu a 2. z druhého intervalu)");
            int soucet;
            for (int i = levaMez1; i <= pravaMez1; i++)
            {
                for (int j = levaMez2; j <= pravaMez2; j++)
                {
                    soucet = i + j;
                    if (((soucet <= pravaMez2) && (soucet >= levaMez2)) || ((soucet <= pravaMez1) && (soucet >= levaMez1)))
                        Console.Write("[{0};{1}], ", i, j);
                }
            }
            Console.ReadKey();
        }
    }
}
