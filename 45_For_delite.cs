namespace _45_For_delitel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vypište všechny dělitele zadaného čísla
            Console.WriteLine("Zadej číslo, pro které chceš hledat dělitele");
            int cislo = int.Parse(Console.ReadLine());

            for (int i = cislo; i > 0; i--)
            {
                if (cislo % i == 0)
                    Console.WriteLine($"{cislo} = {i} * {cislo / i}");
            }
        }
    }
}