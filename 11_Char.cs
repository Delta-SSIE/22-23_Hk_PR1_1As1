using System;

namespace _11_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char pismeno = 'A';
            Console.WriteLine("Písmenko je: " + pismeno);

            // matematika na písmenku (char) 
            char pismeno2 = (char)(pismeno + 10);
            // vytvoří větší typ (integer), proto na začátku "přetypováváme" zpět na char

            // char pismeno2 = (char)(pismeno + 'b');
            Console.WriteLine("Další písmenko je: " + pismeno2);
            Console.ReadKey();
        }
    }
}
