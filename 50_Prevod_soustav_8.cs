namespace _50_Prevod_soustav_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string oktaCislo = "";

            Console.Write("Zadej cislo v desítkové suustavě, které chceš převést: ");
            int cislo = int.Parse(Console.ReadLine());
            int cislo2 = cislo;
            string overeni = Convert.ToString(cislo, 8);
            Console.WriteLine("Prevedená hodnota vestavenou funkcí je: " + overeni);

            while (cislo > 0)
            {
                int zbytek = cislo % 8;
                cislo /= 8;
                oktaCislo = zbytek + oktaCislo;
            }
            Console.WriteLine();
            Console.WriteLine($"Prevedená hodnota {cislo2} desikové soustavy je v osmičkové soustavě: {oktaCislo}");


            Console.ReadKey();

        }
    }
}