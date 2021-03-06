﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryforet
{
    public class Arbre
    {
        int hauteur;
        private List<Feuille> feuilles;

        public Arbre(int hauteur)
        {
            this.hauteur = hauteur;
            feuilles = new List<Feuille>();
        }

        public Arbre(int hauteur, List<Feuille> _feuilles) //ouvre porte aggregation
        {
            this.hauteur = hauteur;
            feuilles = _feuilles;
        }

        public void AddFeuille(Feuille f)
        {
            this.feuilles.Add(f);
        }

        public int Hauteur
        {
            get => hauteur;
            //set => hauteur = value; 
        }


        public void PassageAutomne()
        {
            foreach (Feuille f in feuilles)
            {
                f.CouleursAutomne();
            }
        }

        public void PerdreFeuilles()
        {
            foreach (Feuille f in feuilles)
            {
                f.Tomber();
            }
            feuilles.Clear();
        }

        public override string ToString()
        {
            string str = base.ToString() + "\nHauteur : " + hauteur + "cm";

            if (this.feuilles.Count() > 0)
            {
                str += "\nFeuilles :";
                foreach (Feuille f in feuilles)
                {
                    str += "\n" + f.ToString();
                }
            }
            else
            {
                str += "\nCet arbre n'a pas/plus de feuille !";
            }
            return str;
        }
    }

}

