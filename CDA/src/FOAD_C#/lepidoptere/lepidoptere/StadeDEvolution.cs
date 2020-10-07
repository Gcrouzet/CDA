using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrarylepidoptere
{
    public abstract class StadeDEvolution
    {
        public abstract bool SeDeplacer();

        public abstract StadeDEvolution prochainStade();
    }
}