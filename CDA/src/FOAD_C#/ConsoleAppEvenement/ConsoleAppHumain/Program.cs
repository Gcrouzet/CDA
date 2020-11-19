using ClassLibraryTemp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHumain
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature();
         
            t.Fievre += T_Fievre;
         
            for(int i =0; i < 40; i++)
            {
                t.Monter();
                
            }
            Console.ReadLine();
        }

        private static void T_Fievre()
        {
            Console.WriteLine("Je dois aller chez le médecin, j'ai de la fièvre");
        }
    }
}
