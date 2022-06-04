using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class Mad: Devise,IDevise
    {
        private double tauxdol; 
        private double tauxeur ; 
        
        public Mad() { }
        public Mad(double solde, string sym ,double d , double e):base(solde ,sym)
        {
            this.tauxdol = d;
            this.tauxeur = e;
        }
        public Mad(double solde):base(solde)
        {

        }
        public override Devise ConverTo(string symbole)
        {
           
            Dollars D=new Dollars();
            if (D.verifiersymbole(symbole))
            {
                Dollars M = new Dollars(this.solde * this.tauxdol);
                Console.WriteLine(M.ToString());
                Console.ReadLine();
                return M ;
            }
            else
            {
               Euro Ma = new Euro(this.solde * this.tauxeur);
                Console.WriteLine(Ma.ToString());
                Console.ReadLine();
                return Ma;
            }

        }
        public static Mad operator +(Mad s, Mad S)
        {
            Mad D = new Mad(S.solde + s.solde);
            return D;


        }
        public static Mad operator +(Mad s, double d)
        {
            Mad D = new Mad(s.solde + d);
            return D;
          

        }
        public static Mad operator -(Mad S, Mad s)
        {
            Mad D = new Mad(S.solde - s.solde);
            return D;

        }
        public static Mad operator *(Mad s, double d)
        {
            Mad D = new Mad(s.solde * d);
            return D;
        }

      
        public static Mad operator /(Mad s, int a)
        {
            Mad D = new Mad(s.solde / a);

            return D;
        }

    }
}
