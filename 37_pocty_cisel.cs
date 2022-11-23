namespace _37_pocty_cisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej přirozená čísla, já počítat, kolik bylo jak velkých. Vložením 0 nebo záporného čísla sčítání ukončíš");

            //připravím si počitadla na čísla
            int jednociferna = 0;
            int dvojciferna = 0;
            int trojciferna = 0;
            int vetsi = 0;
            int nacteno;

            // připravím proměnnou na načítání a poprvé do ní uložím
            while (!int.TryParse(Console.ReadLine(), out nacteno))
            {
                Console.WriteLine("Má to být číslo.");
            }

            while (nacteno > 0) //dokud je to kladné, budu pracovat
            {
                if (nacteno < 10) //podle velikosti zvýším některé počitadlo
                    jednociferna++;
                else if (nacteno < 100)
                    dvojciferna++;
                else if (nacteno < 1000)
                    trojciferna++;
                else
                    vetsi++;

                // načtu další číslo
                while (!int.TryParse(Console.ReadLine(), out nacteno))
                {
                    Console.WriteLine("Má to být číslo.");
                } 
            }

            Console.WriteLine($"Celkem bylo vloženo {jednociferna} jednociferných, {dvojciferna} dvojciferných, {trojciferna} trojciferných a {vetsi} větších čísel.");
        }
    }
}