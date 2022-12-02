namespace _46_for_retezec_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej větu:");
            string veta = Console.ReadLine();

            for (int i = 0; i < veta.Length; i++)
            {

                //Console.WriteLine(veta[i]);
                Console.Write(veta[i] + " "); // vloží mezeru mezi znaky
               /* 
                char znak = veta[i];
                Console.Write(znak);
                Console.Write(" ");
                Console.Write((int)znak); //vypíše číslo znaku v ascii https://cs.wikipedia.org/wiki/ASCII
                Console.WriteLine();*/
            }
        }
    }
}