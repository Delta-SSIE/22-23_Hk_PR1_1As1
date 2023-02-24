using System.Net.Sockets;
using System.Reflection.Emit;

namespace _76_Matice_výpočty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radek = vloz_hodnotu("počet řádků");
            int sloupec = vloz_hodnotu("počet sloupců");
            int dolni = vloz_hodnotu("dolní mez generování");
            int horni = vloz_hodnotu("horni mez generování");
            int[,] pole_2D = napln_matici(radek, sloupec, dolni, horni);
            Vypis_matici(pole_2D);
           Soucet_matici(pole_2D);
            int radek_soucet = vloz_hodnotu("radek, který chcš sečíst");
            Soucet_matice_radek(pole_2D, radek_soucet);
            int sloupec_soucet = vloz_hodnotu("sloupce, který chcš sečíst");
            Soucet_matice_sloupec(pole_2D, sloupec_soucet);
            Hledani_minima(pole_2D);
        }

        static int vloz_hodnotu(string text)
        {
            int cislo;
            Console.WriteLine($"\nZadej {text}");
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("\nMá to být číslo.");
            }
            return cislo;
        }

        static int[,] napln_matici(int r, int s, int d, int h)
        {
            Random generator = new Random();
            int[,] pole = new int[s, r];
            for (int j = 0; j < pole.GetLength(1); j++) // řádek
            {
                for (int i = 0; i < pole.GetLength(0); i++) //sloupec
                {
                    pole[i, j] = generator.Next(d, h + 1);
                }
            }
            return pole;
        }

        static void Vypis_matici(int[,] pole2d)
        {
            Console.WriteLine("\nVygenerovaná matice\n");
            for (int j = 0; j < pole2d.GetLength(1); j++)
            {
                for (int i = 0; i < pole2d.GetLength(0); i++)
                {
                    Console.Write(pole2d[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        
        static void Soucet_matici(int[,] pole2d)
        {
            int soucet = 0;
            for (int j = 0; j < pole2d.GetLength(1); j++)
            {
                for (int i = 0; i < pole2d.GetLength(0); i++)
                {
                    soucet += pole2d[i, j];
                }
            }
            Console.WriteLine($"\nSoučet všech prvků v poli je {soucet}.");
        }
        static void Soucet_matice_radek(int[,] pole2d2, int radek_soucet2)
        {
            int soucet_radku = 0;
            for (int i = 0; i < pole2d2.GetLength(0); i++)
            {
                soucet_radku += pole2d2[i, radek_soucet2-1];
            }
            Console.WriteLine($"\nSoučet prvků na {radek_soucet2}. řádku je {soucet_radku}.");
        }

        static void Soucet_matice_sloupec(int[,] pole2d2, int sloupec_soucet2)
        {
            int soucet_sloupec = 0;
            for (int j = 0; j < pole2d2.GetLength(1); j++)
            {
                soucet_sloupec += pole2d2[sloupec_soucet2-1, j];
            }
            Console.WriteLine($"\nSoučet prvků v {sloupec_soucet2}. sloupci je {soucet_sloupec}.");
        }

        static void Hledani_minima(int[,] pole2d)
        {
           int min_v_poli = pole2d[0, 0];
            for (int j = 0; j < pole2d.GetLength(1); j++)
            {
                for (int i = 0; i < pole2d.GetLength(0); i++)
                {
                    if (min_v_poli > pole2d[i, j])
                        min_v_poli = pole2d[i, j];
                }
            }
                Console.WriteLine($"\nMinimální hodnota v pole je {min_v_poli}.");
            }
    }
}