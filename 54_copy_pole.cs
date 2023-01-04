namespace _24_copy_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            Console.WriteLine("Zadej velikost pole");
            int velikost = int.Parse(Console.ReadLine());

            int[] cisla = new int[velikost];
            int[] cisla_zaloha = new int[velikost];

            for (int i = 0; i < velikost; i++)
            {
                cisla[i] = generator.Next(-10, 11);
            }
            for (int i = 0; i < velikost; i++)
            {
                cisla_zaloha[i] = cisla[i];
            }

            Console.WriteLine();
            Console.WriteLine("Původní pole:");
            for (int i = 0; i < velikost; i++)
            {
                Console.Write(cisla[i] + "; ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Záloha pole:");
            for (int i = 0; i < velikost; i++)
            {
                Console.Write(cisla_zaloha[i] + "; ");
            }

            Array.Reverse(cisla); // otočení pole
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Otočení pole:");
            for (int i = 0; i < velikost; i++)
            {
                Console.Write(cisla[i] + "; ");
            }
            Console.ReadKey();
        }
    }
}