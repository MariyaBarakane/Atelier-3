using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class Dollars : Devise , IDevise
    {
        private double tauxmad;
        private double tauxeur;

        public Dollars() { }
        public Dollars(double solde, string sym, double d, double e) : base(solde, sym)
        {
            this.tauxmad = d;
            this.tauxeur = e; 
        }
        public Dollars(double solde) : base(solde) { }
        public override Devise ConverTo(string symbole)
        {
            Mad D = new Mad();
            if (D.verifiersymbole(symbole))
            {
                Mad M = new Mad(this.solde * this.tauxmad);
                
               Console.WriteLine( M.ToString());
                Console.ReadLine();
                return M;
            }
            else
            {
                Euro Ma = new Euro(this.solde * this.tauxeur);
                
                Console.WriteLine(Ma.ToString());
                Console.ReadLine();
                return Ma;
            }

        }
        public static Dollars operator +(Dollars s, Dollars S)
        {
            Dollars D = new Dollars(S.solde + s.solde);
            return D;


        }
        public static Dollars operator +(Dollars s, double d)
        {
            Dollars D = new Dollars(s.solde + d);
            return D;


        }
        public static Dollars operator -(Dollars s, Dollars S)
        {
            Dollars D = new Dollars(S.solde - s.solde);
            return D;

        }
        public static Dollars operator *(Dollars s, double d)
        {
            Dollars D = new Dollars(s.solde * d);
            return D;
        }

    }
}
