using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        private static int addsous(int a, int b, out int sous)
        {
            sous = a - b;
            return a + b;
        }
        static void Main(string[] args)
        {

            int a = 4;
            int b = 2;
            int resultsoustraction;

            int resultaddition = addsous(a, b, out resultsoustraction);


        }


    }
}
