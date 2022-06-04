using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class CompteEpargne : Compte
    {
        private double tauxinteret;
        public CompteEpargne() { }
        public CompteEpargne(Client c , Mad  d, double i):base(c,d) 
        {
            this.tauxinteret = i;
        }
       
        
        public void calculinteret(){
            base.calinteret(this.tauxinteret);
        
          }
        public override bool Debiter(Mad D)
        {
            if (this.checksolde(D))
            {
                base.Debiter(D);
            }
            return false;
        }
    }
}
