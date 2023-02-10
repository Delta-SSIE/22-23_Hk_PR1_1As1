using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DatumCas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Získání aktuální datumu a času + uložení do proměnné
            DateTime aktualniDatumCas = DateTime.Now;
            
            // Získání jednotlivých složek datumu a času
            // Rok (celé číslo)
            Console.WriteLine("aktualniDatumCas.Year: {0}", aktualniDatumCas.Year);
            // Měsíc (celé číslo) 
            Console.WriteLine("aktualniDatumCas.Month: {0}", aktualniDatumCas.Month);
            // Den (celé číslo)
            Console.WriteLine("aktualniDatumCas.Day: {0}", aktualniDatumCas.Day);
            // Hodiny (celé číslo)
            Console.WriteLine("aktualniDatumCas.Hour: {0}", aktualniDatumCas.Hour);
            // Minuty (celé číslo)
            Console.WriteLine("aktualniDatumCas.Minute: {0}", aktualniDatumCas.Minute);
            // Sekundy (celé číslo)
            Console.WriteLine("aktualniDatumCas.Second: {0}", aktualniDatumCas.Second);
            // Milisekundy (celé číslo)
            Console.WriteLine("aktualniDatumCas.Millisecond: {0}", aktualniDatumCas.Millisecond);
            Console.ReadKey();

            // Znovu získáme aktuální datum a čas
            DateTime aktualniDatumACas2 = DateTime.Now;
            // Získáme aktuální datum s tím, že složky mimo rok, měsíc a den jsou anulovány
            DateTime aktualniDatum = aktualniDatumCas.Date;

            // Zkusíme porovnat proměnné
            Console.WriteLine("aktualniDatumCas == aktualniDatumACas2 : {0}", aktualniDatumCas == aktualniDatumACas2);
            Console.WriteLine("aktualniDatum == aktualniDatumCas.Date : {0}", aktualniDatum == aktualniDatumACas2.Date);
            Console.ReadKey();

            // Další možnosti porovnávání datumů
            Console.WriteLine("Porovnani aktualniDatum a aktualniDatumCas.Date");
            Console.WriteLine(" > {0}",aktualniDatum > aktualniDatumCas.Date);
            Console.WriteLine(" >= {0}",aktualniDatum >= aktualniDatumCas.Date);
            Console.WriteLine(" == {0}",aktualniDatum == aktualniDatumCas.Date);
            Console.WriteLine(" <= {0}",aktualniDatum <= aktualniDatumCas.Date);
            Console.WriteLine(" < {0}",aktualniDatum < aktualniDatumCas.Date);
            
            // Vytvoříme datum ze zadaných čísel - rok, měsíc, den
            DateTime datumNarozeni = new DateTime(1984,3,29);
            // Další varianta vytvoření - rok, měsíc, den, hodina, minuta, vteřina
            DateTime datumNakupu = new DateTime(2015,8,30,15,30,49);
            
            // Výpisy datumu na konzoli
            Console.WriteLine("DateTime.Now: {0}", DateTime.Now);
            Console.WriteLine("DateTime.ToShortDateString(): {0}", DateTime.Now.ToShortDateString());
            Console.WriteLine("DateTime.ToShortTimeString(): {0}", DateTime.Now.ToShortTimeString());
            
            // Přičítání k datumu a času
            DateTime datumNastupu = new DateTime(2014, 4, 11);
            // Pozor na to, že výsledkem přičtení je nový datum a čas posunutý
            // o příslušnou hodnotu. Původní hodnota proměnné zůstává beze změny!
            DateTime posunuteDatum = datumNastupu.AddYears(1);
            Console.WriteLine("posunuteDatum: {0}",posunuteDatum);
            Console.WriteLine("datumNastupu: {0}",datumNastupu);

            Console.WriteLine("datumNastupu.AddMonths(3): {0}", datumNastupu.AddMonths(3));
            Console.WriteLine("datumNastupu.AddDays(30): {0}", datumNastupu.AddDays(30));
            Console.WriteLine("datumNastupu.AddHours(47): {0}", datumNastupu.AddHours(47));
            Console.WriteLine("datumNastupu.AddMinutes(22): {0}", datumNastupu.AddMinutes(22));
            Console.WriteLine("datumNastupu.AddSeconds(181): {0}", datumNastupu.AddSeconds(181));
            Console.WriteLine("datumNastupu.AddMilliseconds(9512): {0}", datumNastupu.AddMilliseconds(9512));

            // Odečítání od datumu a času
            Console.WriteLine("datumNastupu.AddYears(-2): {0}", datumNastupu.AddYears(-2));
            Console.WriteLine("datumNastupu.AddHours(-20): {0}", datumNastupu.AddHours(-20));
            // ...
            Console.ReadKey();
        }
    }
}

