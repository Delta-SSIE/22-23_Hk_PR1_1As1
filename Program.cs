using System;

namespace _08_Info_o_zakovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte své jméno:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte své přijmení:");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte školu kam chodíš:");
            string skola = Console.ReadLine();
            Console.WriteLine("Zadejte své třídu kam patříš:");
            string trida = Console.ReadLine();
            string info;
            info = "Jmenuji se " + jmeno + " " + prijmeni+".";
            info = info + " Chodím do školy " + skola+".";
            info = info + " Zde chodím do třídy " + trida;
            Console.WriteLine(info);
            Console.ReadKey();
        }
    }
}
