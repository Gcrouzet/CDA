using Design_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression exp1 = new Addition(new Nombre(33),new Addition( new Nombre(33),new Nombre(11)));
            int resultat1 = exp1.Evalue();

            Expression exp2 = new Soustraction(new Nombre(33), new Nombre(33));
            int resultat2 = exp2.Evalue();


            Expression exp3 = new Addition(new Nombre(7),new Soustraction (new Nombre(3), new Nombre(6)));
            int resultat3 = exp3.Evalue();
            exp3.Formate();
        }
    }
}
