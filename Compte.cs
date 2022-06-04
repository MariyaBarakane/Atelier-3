using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class Compte
    {
        private readonly Client Client;
        private readonly int numc;
        private static int Cpt;
        private Mad solde;
        private List<Operations> op;

        public Compte()
        {
            

        }
        public Compte(Client c, Mad d)
        {
            this.numc = ++Cpt;
            this.Client = c;
            this.solde = d;
            this.op = new List<Operations>();
                
                }
        public override string ToString()
        {
            string S;
           
            foreach (Operations i in op)
            {
                i.ToString();
            }

            S = "les info du compte  "+ this.numc +":\n" +this.Client.ToString() + "\n"  +"le solde est :" +this.solde.ToString() + "\n";
                foreach (Operations i in op)
            {
                   S+=i.ToString()+"\n";
            }

            return S;
        }
        public virtual void Crediter(Mad D)
        {
            this.solde = this.solde + D;
            Operations OP = new Operations(D, "+");
            this.op.Add(OP);
        }
        public virtual bool Debiter(Mad D)
        {
            Mad Plafond = new Mad(20000);


            if (D < Plafond)
            {
                this.solde = this.solde - D;
                Operations OP = new Operations(D, "-");
                this.op.Add(OP);
                return true;
            }
            else
            {
                Console.WriteLine("ERR:impossible d'effectuer ce retrait !");
                Console.ReadKey();
                return false;
            }
        }
        public virtual bool transfererargent(Compte c, Mad D)
        {
            if (this.Debiter(D))
            {
                c.Crediter(D);
                return true;
            }
            else
            {
                Console.WriteLine("ERR:impossible d'effectuer le virement!");
                Console.ReadKey();
                return false;
            }

        }
        public void calinteret(double i)
        {
            this.solde += this.solde * i;

        }
        public bool Decouvert(Mad dec, Mad m)
        {
            return (dec + this.solde > m);
        }
        public bool checksolde(Devise d)
        {
            return this.solde / 2 > d;
        }

    } 



}
