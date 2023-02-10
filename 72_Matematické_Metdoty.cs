using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CastoPouzivaneMetodyProPraciSCislyARetezci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Výpočet absolutní hodnoty
            Console.WriteLine("Math.Abs(-5.5) = {0}",Math.Abs(-5.5));
            // Vrátí nejbližší větší nebo rovné celé číslo
            Console.WriteLine("Math.Ceiling(3.1) = {0}", Math.Ceiling(3.1));
            // Vrátí nejbližší menší nebo rovné celé číslo
            Console.WriteLine("Math.Floor(3.7) = {0}", Math.Floor(3.7));
            // Vrátí danou mocninu příslušného číslo. Tedy např. "dvě na čtvrtou"
            Console.WriteLine("Math.Pow(2, 4) = {0}", Math.Pow(2, 4));
            // Zaokrouhlí dané číslo
            Console.WriteLine("Math.Round(5.5) = {0}", Math.Round(5.5));
            // Spočítá odmocninu z daného čísla
            Console.WriteLine("Math.Sqrt(100) = {0}", Math.Sqrt(100));
            Console.ReadKey();

            // Sloučí řetězce do jednoho řetězce
            string[] poleRetezcu = {"Jedna","Dva","Tri"};
            Console.WriteLine("String.Concat(poleRetezcu): {0}", String.Concat(poleRetezcu));
            // Vrací true/false podle toho, zdali je řetězec prázdný
            Console.WriteLine("String.IsNullOrEmpty(\"\"): {0}", String.IsNullOrEmpty(""));
            Console.WriteLine("String.IsNullOrEmpty(\" \"): {0}", String.IsNullOrEmpty(" "));
            // Vrací true/false podle toho, zdali je řetězec prázdný. Za prázdný řetězec považuje i ten
            // který obsahuje pouze mezery
            Console.WriteLine("String.IsNullOrEmpty(\"\"): {0}", String.IsNullOrWhiteSpace(""));
            Console.WriteLine("String.IsNullOrEmpty(\" \"): {0}", String.IsNullOrWhiteSpace(" "));
            
            string retezec1 = "Pavel";
            // Vrací true/false podle toho zdali v sobě daný řetězec obsahuje řetězec, který je předán jako parametr
            Console.WriteLine("retezec1.Contains(\"a\"): {0}",retezec1.Contains("a"));
            Console.WriteLine("retezec1.Contains(\"a,b,c\"): {0}", retezec1.Contains("a,b,c"));
            Console.WriteLine("retezec1.Contains(\"a,b, \"): {0}", retezec1.Contains("a,b, "));
            
            // Vrací počet znaků v řetezci
            Console.WriteLine("retezec1.Length: {0}", retezec1.Length);

            // Vrací true/false podle toho zdali daný řetězec končí řetězcem, který je předán jako parametr
            Console.WriteLine("retezec1.EndsWith(\"el\"): {0}",retezec1.EndsWith("el"));
            Console.WriteLine("retezec1.EndsWith(\"ova\"): {0}",retezec1.EndsWith("ova"));
            // Vrací true/false podle toho zdali daný řetězec začíná řetězcem, který je předán jako parametr
            Console.WriteLine("retezec1.StartsWith(\"P\"): {0}",retezec1.StartsWith("P"));
            Console.WriteLine("retezec1.StartsWith(\"Pe\"): {0}", retezec1.StartsWith("Pe"));
             
            string retezec2 = "Kvetoslava";
            // K jednotlivým znakům v řetězci můžete přistoupit pomocí indexů obdobně jako když jste přistupovali
            // k prvkům pole
            Console.Write("Vypis znaku v retezci na pozicich 2, 4, 5: ");
            Console.Write(retezec2[0]);
            Console.Write(retezec2[4]);
            Console.Write(retezec2[5]);

            // Vrátí index prvního výskytu daného řetězce. Pokud řetězec neobsahuje hledaný řetězec, pak vrací -1
            Console.WriteLine("retezec2.IndexOf(\"a\"): {0}", retezec2.IndexOf("a"));
            // Vrátí index prvního výskytu daného řetězce, přičemž vyhledávání probíhá od předaného indexu.
            // Pokud řetězec neobsahuje hledaný řetězec, pak vrací -1
            Console.WriteLine("retezec2.IndexOf(\"a\", 7): {0}", retezec2.IndexOf("a", 7));            

            // Z daného řetězce odstraní znaky od daného indexu dále a takto zkrácený řetězec vrátí
            string retezec3 = retezec2.Remove(7);
            Console.WriteLine("retezec2.Remove(7): {0}", retezec3);
            // Z daného řetězce odstraní daný počet znaků od daného indexu dále a takto zkrácený řetězec vrátí
            string retezec4 = retezec2.Remove(7,1);
            Console.WriteLine("retezec2.Remove(7,1): {0}", retezec4);
            // Vrátí podřetězec, který začíná na daném indexu
            string retezec5 = retezec2.Substring(5);
            Console.WriteLine("retezec2.Substring(5): {0}", retezec5);
            // Vrátí podřetězec, který bude mít danou délku a který začíná na daném indexu
            string retezec6 = retezec2.Substring(5,3);
            Console.WriteLine("retezec2.Substring(5,3): {0}", retezec6);
            // Vrátí řetězec ve kterém budou všechna písmena převedena na malá
            string retezec7 = retezec2.ToLower();
            Console.WriteLine("retezec2.ToLower(): {0}", retezec7);
            // Vrátí řetězec ve kterém budou všechna písmena převedena na velká
            string retezec8 = retezec2.ToUpper();
            Console.WriteLine("retezec2.ToUpper(): {0}", retezec8);
            // Vrátí řetězec, ve kterém budou výskyty hledaného řetězce nahrazeny druhým řetězcem
            string retezec9 = retezec2.Replace("va", "v");
            Console.WriteLine("retezec2.Replace(\"va\", \"v\"): {0}", retezec9);

            string retezec10 = " Petr  ";
            // Vrátí řetězec, ve kterém budou odstraněny veškeré počáteční a koncové mezery
            string retezec11 = retezec10.Trim();
            Console.WriteLine("retezec11 == \"Petr\": {0}",retezec11 == "Petr");

            Console.ReadKey();
        }
    }
}
