using System;

namespace _09_Hledani_ve_vete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string veta;
             Console.WriteLine("Zadej email na doméně CZ:");
             veta = Console.ReadLine();
             bool zavinac;
             zavinac = veta.Contains("@");
             Console.WriteLine($"Je zadán email? {zavinac}");

             bool tecka;
             tecka = veta.EndsWith(".cz");
             Console.WriteLine($"Je email na doméně .cz? {tecka}");

             int delka; //definuji proměnou datového typu integer = celé číslo
             delka = veta.Length; // do proměnné délka načtu počet znaků ve větě
             Console.WriteLine($"Delka zadného emialu je: {delka}");



            // Nahrazení slova ve větě 
            string s = "Java je nejlepší!";
            Console.WriteLine(s);
            s = s.Replace("Java", "C#");
            Console.WriteLine(s);
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
