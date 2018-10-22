using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokace
{
    class Lokace
    {
        public string meno;
        public string popis;
        public Lokace sever;
        public Lokace juh;
        public Lokace vychod;
        public Lokace zapad;

        public Lokace(string meno, string popis, Lokace sever = null, Lokace juh = null, Lokace vychod = null, Lokace zapad = null)
        {
            this.meno = meno;
            this.popis = popis;
            this.sever = sever;
            this.juh = juh;
            this.vychod = vychod;
            this.zapad = zapad;
        }


    }
}
