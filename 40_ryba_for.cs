namespace _40_ryba_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik ryb si dáš k večeři?");
            int pocet = int.Parse(Console.ReadLine());
            int i = 0;
           while (pocet>i)
            {
                i++;
                Console.WriteLine("<° )))-<");
                Console.WriteLine();
            }


            /*
            Console.WriteLine("Kolik ryb si dáš k večeři?");
            int pocet = int.Parse(Console.ReadLine());
            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine("<° )))-<");
                Console.WriteLine();
            }*/
            Console.ReadKey();
        }
    }
}