using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo
{
    public class Gardien : IParler, IDeplacable
    {
        public Gardien()
        {
        }

        public bool SeDeplacer()
        {
            Console.WriteLine("Je marche lentement aussi , je ne suis pas tout jeune");
            return true;
        }
        public bool Parler()
        {
            Console.WriteLine("allo les pompiers , le zoo a brûlé(gardien)");
            return true;
        }
    }
}
