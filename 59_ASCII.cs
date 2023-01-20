namespace _59_ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            char c; // znak
            int i; // ordinální (ASCII) hodnota znaku
                   // převedeme znak na jeho ASCII hodnotu
            c = 'a';
            i = (int)c;
            Console.WriteLine("Znak {0} jsme převedli na ASCII hodnotu {1}", c, i);
            // Převedeme ASCII hodnotu na znak
            i = 98;
            c = (char)i;
            Console.WriteLine("ASCII hodnotu {1} jsme převedli na znak {0}", c, i);
            Console.ReadKey();
        }*/











            Console.WriteLine("ASCII tabulka");
            Console.WriteLine("=============");
            for (int i = 0; i < 256; i++)
            {
                char znak = (char)i;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(i + ":");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(znak + "\t");
            }
            Console.ReadKey();
        }
    }
}