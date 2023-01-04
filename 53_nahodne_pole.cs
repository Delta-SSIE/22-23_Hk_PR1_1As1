namespace _53_náhodné_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            Console.WriteLine("Zadej velikost pole");
            int velikost = int.Parse(Console.ReadLine());

            int[] cisla = new int[velikost];

            for (int i = 0; i < velikost; i++)
            {

                cisla[i] = generator.Next(-10, 11);
            }

            Console.WriteLine();
            Console.WriteLine("Původní pole:");
            for (int i = 0; i < velikost; i++)
            {

                Console.Write(cisla[i] + "; ");
            }
           Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Seřazené pole od min do max:");
            Array.Sort(cisla);
            foreach (int h in cisla)
                Console.Write(h + "; ");
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine("Seřazené pole od max do min:");
             for (int i = (velikost-1); i >=0; i--)
             {
                 Console.Write(cisla[i] + "; ");
             }
            Console.ReadKey();
           
        }
    }
}