using System;

namespace _13_Podmínka_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej svůj věk");
            int vek = int.Parse(Console.ReadLine());
            if (vek < 21) // definuji podmínku
            // Zde se vyková kód při splní prodmínky
            {
                Console.WriteLine("Není ti 21, takže si dáš Colu :)");
            }
            else // zde se vykoná kód pri NESPLNĚNÍ podmínky
            {
                Console.WriteLine("Alkohol již můžeš, ale s ROZUMEM");
            }
            Console.ReadKey();
        }
    }
}
