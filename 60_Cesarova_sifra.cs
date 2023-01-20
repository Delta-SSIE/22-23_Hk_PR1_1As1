namespace _60_Cesarova_sifra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inicializace proměnných
            Console.WriteLine("Zadej text pro šifrování");
            string s = Console.ReadLine();
            s = s.ToLower(); // prevod na malá písmena
            Console.WriteLine("Původní zpráva je malá písmena: {0}", s);
            string zprava_bez_mezera = "";
            string zprava = "";
            // vynechání mezer
            for (int a = 0; a < s.Length; a++)
            {
                if (s[a] != ' ')
                {
                    zprava_bez_mezera += s[a];
                }
            }
            Console.WriteLine("Původní text bez mezer: "+zprava_bez_mezera);
            
            // cyklus projíždějící jednotlivé znaky
            Console.WriteLine("Zadej posun");
            int posun = int.Parse(Console.ReadLine());
            
            foreach (char c in zprava_bez_mezera)
            {

                int i = (int)c;
                i += posun;
                char znak = (char)i;
                zprava += znak;

            }

            // výpis
            Console.WriteLine("Zašifrovaná zpráva: {0}", zprava);
            Console.ReadKey();
        }
    }
}