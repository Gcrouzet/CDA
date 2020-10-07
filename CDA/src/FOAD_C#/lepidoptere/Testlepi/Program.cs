using ClassLibrarylepidoptere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlepi
{
    class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere l = new Lepidoptere(new DateTime(1212, 01, 04));
            l.SeDeplacer();
            l.SeMetamorphoser();
            Console.ReadLine();
        }
    }
}
