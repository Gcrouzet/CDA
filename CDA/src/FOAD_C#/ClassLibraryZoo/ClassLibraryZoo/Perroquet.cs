﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo
{
    public class Perroquet : AnimalDuZoo, IParler
    {
        public Perroquet(DateTime dateDeNaissance, bool estNeeAuZoo) : base(dateDeNaissance, estNeeAuZoo)
        {
        }

        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je vole!");
            return true;
        }
        public override bool Parler()
        {
            Console.WriteLine("allo les pompiers , il y a le zoo qui brûle(perroquet)");
            return true;
        }
    }
}
