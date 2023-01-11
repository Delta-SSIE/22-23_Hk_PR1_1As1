namespace _56_prace__s_polem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] pole = new int[20];
            for (int i = 0; i < 20; i++)
            {
                pole[i] = generator.Next(-5, 6);
                Console.Write(pole[i] + " | ");
            }

            int pocet_nul = 0;
            Console.WriteLine();
            Console.Write("Pozice nul:");
            for (int i = 0; i < 20; i++) // hledá pozice nulových hodnot
            {
               if (pole[i] == 0)
                { 
                Console.Write((i + 1) + " , "); // vypisuji jednoltivé pozice
                    pocet_nul++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pocet nulových hodnot v poli je: " + pocet_nul);
            // poslední výskyt nuly
            int pozice_last = -1;
            for (int i = 0; i < 20; i++) // hledá pozice nulových hodnot
            {
                if (pole[i] == 0)
                {
                    pozice_last = i;  
                }
            }
            if (pozice_last == -1)
                Console.WriteLine("Hodnota nula je v poli nevyskyzuje");
            else
                Console.WriteLine("Poslení pozice hodnoty nula je: "+(pozice_last+1));
           
            int posledni_vykyt = Array.LastIndexOf(pole, 0);
            Console.WriteLine("Poslední výskyt hodnoty 0 je na pozici: " + (posledni_vykyt+1));

            int pozice_first = -1;
            for (int i = 0; i < 20; i++) // hledá pozice nulových hodnot
            {
                if (pole[i] == 0)
                {
                    pozice_first = i;
                    break;
                }
            }

            if (pozice_first == -1)
                Console.WriteLine("Hodnota nula je v poli nevyskyzuje");
            else
                Console.WriteLine("První pozice hodnoty nula je: " + (pozice_first + 1));

            int pozice_first_2 = -1;
            bool hledani = true;
            for (int i = 0; i < 20; i++) // hledá pozice nulových hodnot
            {
                if (pole[i] == 0 && hledani)
                {
                    pozice_first_2 = i;
                    hledani = false;
                }
            }

            if (pozice_first_2 == -1)
                Console.WriteLine("Hodnota nula je v poli nevyskyzuje");
            else
                Console.WriteLine("První pozice hodnoty nula je: " + (pozice_first_2 + 1));

            int prvni_vykyt = Array.IndexOf(pole, 0);
            Console.WriteLine("První výskyt hodnoty 0 je na pozici: " + (prvni_vykyt+1));

            /*
                        int prvni_vykyt = Array.IndexOf(pole, 0);
                        Console.WriteLine("První výskyt hodnoty 0 je na pozici: " + prvni_vykyt);
                        int posledni_vykyt = Array.LastIndexOf(pole, 0);
                        Console.WriteLine("Poslední výskyt hodnoty 0 je na pozici: " + posledni_vykyt);

                        int prvni_prvek = pole.First();
                        Console.WriteLine("Hodnota prvku na pozici 1 je: " + prvni_prvek);
                        int posledni_prvek = pole.Last();
                        Console.WriteLine("Hodnota prvku na pozici "+pole.Length+" je: " + posledni_prvek);
             */



            Console.ReadKey();
        }

    }
 
}