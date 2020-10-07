using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrarylepidoptere
{
    public class papillon : StadeDEvolution
    {
        public override bool SeDeplacer()
        {
            Console.WriteLine("Je vole");
            return true;
        }

        public override StadeDEvolution prochainStade()
        {
            return new papillon();
        }
    }
}