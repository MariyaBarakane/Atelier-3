using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class Euro : Devise, IDevise
    {
        private double tauxmad;
        private double tauxdol;

        public Euro() { }
        public Euro(double solde, string sym, double m, double e) : base(solde, sym)
        {
            this.tauxmad = m;
            this.tauxdol = e;
        }
        public Euro(double solde) : base(solde) { }
        public override Devise ConverTo(string symbole)
        {
            Mad D = new Mad();
            if (D.verifiersymbole(symbole))
            {
                Mad M = new Mad(this.solde * this.tauxmad);
                Console.WriteLine(M.ToString());
                Console.ReadLine();
                return M;
            }
            else
            {
                Dollars Ma = new Dollars(this.solde * this.tauxdol);
                Console.WriteLine(Ma.ToString());
                Console.ReadLine();
                return Ma;
            }
        }
        public static Euro operator +(Euro s, Euro S)
        {
            Euro D = new Euro(S.solde + s.solde);
            return D;


        }
        public static Euro operator +(Euro s, double d)
        {
            Euro D = new Euro(s.solde + d);
            return D;


        }
        public static Euro operator -(Euro s, Euro S)
        {
            Euro D = new Euro(S.solde - s.solde);
            return D;

        }
        public static Euro operator *(Euro s, double d)
        {
            Euro D = new Euro(s.solde * d);
            return D;
        }
    }
}
