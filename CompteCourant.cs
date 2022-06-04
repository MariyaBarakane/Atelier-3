using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class CompteCourant:Compte
    {
        private Mad decouvert;
        public CompteCourant() { }
        public CompteCourant(Client c , Mad d ,Mad dec) :base(c,d)
        {
            this.decouvert = dec;
        }
        public override bool Debiter(Mad d) {
            if (base.Decouvert(this.decouvert, d))
            {
                base.Debiter(d);
            }
            return false;
        }
        public override bool transfererargent(Compte c, Mad D)
        {
            if (this.Debiter(D))
            {
                c.Crediter(D);
                return true; 
            }
            Console.WriteLine("ERR:impossible d'effectuer le virement!");
            Console.ReadKey();
            return false;
        }
    }
}
