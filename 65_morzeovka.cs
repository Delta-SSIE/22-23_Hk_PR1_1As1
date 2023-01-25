namespace _65_morzeovka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // řetězec, který chceme dekódovat
            string s = ".. ... .-.. .- -. -.. ... --- ..-. -";
            Console.WriteLine("Původní zpráva: {0}", s);
            // řetězec s dekódovanou zprávou
            string zprava = "";

            // vzorová pole
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
            "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
            "...-", ".--", "-..-", "-.--", "--.."};

            // rozbití řetězce na znaky morzeovky
            string[] znaky = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // iterace znaků morzeovky
            foreach (string morseuvZnak in znaky)
            {
                char abecedniZnak = '?';
                int index = Array.IndexOf(morseovyZnaky, morseuvZnak);
                if (index >= 0) // znak nalezen
                    abecedniZnak = abecedniZnaky[index];
                zprava += abecedniZnak;
            }

            // výpis
            Console.WriteLine("Dekódovaná zpráva: {0}", zprava);
            Console.ReadKey();
        }
    }
}