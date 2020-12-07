using ClassLibraryCake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestCake
{
    class Program
    {
        static void Main(string[] args)
        {

            Cake cake1 = new Cake();
            cake1.Cuire();

            cake1.GateauCuit += Cake1_GateauCuit;

            Console.ReadLine();
        }

        private static void Cake1_GateauCuit()
        {
            Console.WriteLine("le Gateau est cuit");
        }
    }
}
