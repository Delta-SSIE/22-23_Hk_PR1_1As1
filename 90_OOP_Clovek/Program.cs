using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lide
{
    /*
    Naprogramujte aplikaci, která obsluhuje člověka. Člověk
má jméno a únavu, která je zpočátku 0. Může uběhnout
určitou vzdálenost a také spát určitou dobu. Běháním se jeho únava
zvyšuje (1 jednotka únavy na 1 km), spaním se snižuje
(10 jednotek únavy na 1 hodinu). Navrhněte třídu tak, aby se
únava nikdy nemohla dostat z rozmezí 0-20 jednotek.
Samozřejmě vám k tomu pomůže zapouzdření, únava určitě nebude
veřejným atributem.

Program vyzkoušíte tak, že necháte člověk 3x uběhnout 10
km. Třetí uběhnutí by se nemělo povést. Když člověka necháte po
druhém uběhnutí hodinu spát, zvládne i třetí běh.

Na úvod vypište instanci člověka. Definujte mu metodu
ToString() tak, aby se vypsalo jeho jméno a věk.
*/

    class Program
    {
        static void Main(string[] args)
        {
            Clovek karel = new Clovek("Karel Nový", 25);
            Console.WriteLine(karel);
            karel.Behej(10);
            karel.Behej(10);
            karel.Spi(1);
            karel.Behej(10);
            Console.ReadKey();
        }
    }
}
