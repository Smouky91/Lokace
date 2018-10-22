using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lokace
{
    class Hra
    {
        public static Lokace pozicia;
       
        public Hra(Lokace lokace)
        {
            pozicia = lokace;

        }
        public static void JdiNa(string lokace)
        {
            switch (lokace)
            {
                case "jdi na sever":
                    pozicia = pozicia.sever;
                    break;
                case "jdi na jih":
                    pozicia = pozicia.juh;
                    break;
                case "jdi na západ":
                    pozicia = pozicia.zapad;
                    break;
                case "jdi na východ":
                    pozicia = pozicia.vychod;
                    break;
                case "Konec":
                    pozicia = null;
                    break;

            }
            
        }

        public static void Vypis(Lokace lokace)
        {
            Console.Write("{0} \n{1} \n\nMůžeš jít na", lokace.meno, lokace.popis);
            if (lokace.sever != null)
                Console.Write(" sever");
            if (lokace.juh != null)
                Console.Write(" jih");
            if (lokace.vychod != null)
                Console.Write(" východ");
            if (lokace.zapad != null)
                Console.Write(" západ");
        }
             
    }
}
