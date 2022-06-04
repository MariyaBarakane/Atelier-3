using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
     abstract internal class Devise:IDevise
    {
        protected double solde;
        protected string symbole;

        public Devise() { }
        public Devise(double s,string dev)
        {
            this.solde = s;
            this.symbole = dev; 
        }
        public Devise(double s)
        {
            this.solde = s;
           
        }
        public override string ToString()
        {
            string s; 
            s= this.solde + this.symbole;
           
            return s;
        }
         abstract public Devise ConverTo(string symbole);



       


     
        public static bool operator <(Devise s, Devise S)
        {

            return (s.solde < S.solde);
           

        }
        public static bool operator >(Devise s, Devise S)
        {

            return (s.solde > S.solde);
        }
       
        public bool verifiersymbole(string sym)
        {
            if (this.symbole== sym)
            {
                return true;

            }
            return false;
        }
    }


}
