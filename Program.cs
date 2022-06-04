using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    internal class Program
    {
        static void Main(string[] args)
        {   Client c = new Client("n1", "c1", "ad1");
            Client c2 = new Client("n2", "c2", "ad2");
            Mad d = new Mad(10000);
            Mad dev = new Mad(200,"Mad", 0.1, 0.2);
            Mad cr = new Mad(5000,"Mad",0.1,0.2);
            Dollars pl = new Dollars(20000,"dollars",0.3,0.4);
            Compte C = new Compte(c, d);
            CompteCourant CC = new CompteCourant(c2, cr,d);
            CompteEpargne CE = new CompteEpargne(c2, cr,0.5);
           Console.WriteLine(C.ToString());
            Console.ReadKey();
            C.Crediter(cr);
            C.Debiter(dev);
            Console.WriteLine(C.ToString());
            Console.ReadKey();
            CC.Debiter(dev);
            Console.WriteLine(CC.ToString());
            Console.ReadKey();
            C.transfererargent(CE, cr);
            Console.WriteLine(CE.ToString());
            Console.ReadKey();
            Console.WriteLine(C.ToString());
            Console.ReadKey();
            pl.ConverTo("Mad");
           

        }
    }
}
