using ClassLibraryZoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IParler> mesParleurs = new List<IParler>();
            List<IDeplacable> monZoo = new List<IDeplacable>();
            List<AnimalDuZoo> mesAnimauxDuZoo = new List<AnimalDuZoo>();
            mesAnimauxDuZoo.Add(new Lapin(new DateTime(1994, 07, 21), true));
            mesAnimauxDuZoo.Add(new Lapin(new DateTime(1990, 07, 20), true));
            mesAnimauxDuZoo.Add(new Lion(new DateTime(1991, 06, 08), true));
            mesAnimauxDuZoo.Add(new Perroquet(new DateTime(2019, 03, 25), true));
            Gardien georges = new Gardien();
            monZoo.Add(georges);
            foreach (AnimalDuZoo a in mesAnimauxDuZoo)
            {
                monZoo.Add(a);
            }
            foreach (AnimalDuZoo a in mesAnimauxDuZoo)
            {
                if (a is IParler)
                {
                    mesParleurs.Add((IParler)a);
                }
            }

            mesParleurs.Add(georges);

            //le feu arrive, il faut deplacer tout le monde
            foreach (AnimalDuZoo a in mesAnimauxDuZoo)
            {
                a.SeDeplacer();
            }




            //il faut mettre un peu d'ordre dans l'evacuation...du plus vieux au plus jeune


            mesAnimauxDuZoo.Sort();

            foreach (AnimalDuZoo a in mesAnimauxDuZoo)
            {
                a.SeDeplacer();
            }

            //mais que fait le gardien? il reste sur place?

            foreach (IDeplacable d in monZoo)
            {
                d.SeDeplacer();
            }

            //et qui va appeller les secours? 


            //foreach (AnimalDuZoo a in mesAnimauxDuZoo)
            //{
            //    a.Parler();
            //}
            //georges.Parler();
            foreach (IParler p in mesParleurs)
            {
                p.Parler();
            }


            Console.ReadLine();
        }
    }
}
