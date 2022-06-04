using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class ComptePayant:Compte
    {
        private static double payment = 0.5;

        public ComptePayant() { }
        public ComptePayant(double p) {
            payment = p; 
        }
        public override bool Debiter(Mad D)
        {
            Mad dev = new Mad();
            dev = D + payment;
            return base.Debiter(dev);
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
