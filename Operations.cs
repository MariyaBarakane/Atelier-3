using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class Operations
    {
        private int num;
        private static int cpt;
        private DateTime date;
        private Devise d;
        private string lib;

        public Operations() { 
        }
      
        public Operations(Devise d , string l ) {
            this.num = ++cpt;
            this.d = d;
            this.lib = l;
        }
        public override string ToString()
        {
            string s = this.date.ToString() + "|n°" + this.num + "||" + this.lib + this.d.ToString();
            Console.ReadKey();
            return s ;
        }
    }
}
