using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarylepidoptere
{
    public class Chenille : StadeDEvolution
    {
        public override bool SeDeplacer()
        {
            Console.WriteLine("Je rampe");
            return true;
        }

        public override StadeDEvolution prochainStade()
        {
            return new Chrysalide();
        }

    }
}
