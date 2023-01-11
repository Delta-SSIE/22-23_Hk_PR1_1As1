namespace _57_prvek_v_poli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

             string fruit = "mango";

             bool hasMango = fruits.Contains(fruit);

             Console.WriteLine(
                 "The array {0} contain '{1}'.",hasMango ? "does" : "does not", fruit);
            */

            Random generator = new Random();
            int[] pole = new int[10];
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = generator.Next(0, 11);
                Console.Write(pole[i] + " | ");
            }

            Console.WriteLine();
            Console.Write("Zadej hledané číslo:");
            int cislo = int.Parse(Console.ReadLine());

            bool nalazeno = pole.Contains(cislo);
            Console.WriteLine("V poli se hodnota {0} {1}.",cislo, nalazeno ? "Nachází" : "Nenachází");
        }

    }
}