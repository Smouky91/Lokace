using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokace
{
    class Program
    {
        static void Main(string[] args)
        {
            Lokace hrad = new Lokace("Hrad", "Strasidelny hrad Krala Filistina");
            Lokace les = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
            Lokace razcestie = new Lokace("Lesní rozcestí", "Nacházíš se na lesním rozcestí.");
            Lokace les1 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
            Lokace les2 = new Lokace("Les", "Jsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.");
            Lokace plaz = new Lokace("Rybník", "Došel jsi ke břehu malého rybníka. Hladina je v bezvětří jako zrcadlo. Kousek od tebe je dřevěná plošina se stavidlem.");
            Lokace dom = new Lokace("Dům", "Rodny dom");
            hrad.sever = les;
            les.zapad = hrad;
            les.vychod = razcestie;
            razcestie.zapad = les;
            razcestie.vychod = les1;
            razcestie.juh = les2;
            les1.zapad = razcestie;
            les1.vychod = plaz;
            les2.sever = razcestie;
            les2.vychod = dom;
            dom.zapad = les2;
            plaz.zapad = les1;

            Hra.pozicia = les2;
            while (Hra.pozicia != null)
            {
                Hra.Vypis(Hra.pozicia);
                Console.Write("\n\nZadej příkaz: ");
                Hra.JdiNa(Console.ReadLine());
            }
        }
    }
}
