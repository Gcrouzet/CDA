using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppSynthese
{
    class Pret
    {
        private int capital;
        private float taux;
        private int nbDeRemboursement;
        private double montantParRemboursement;

        public Pret()
        {
        }

        public Pret(int capital, float taux, int nbDeRemboursement, double montantParRemboursement)

        {
            this.capital = capital;
            this.taux = taux;
            this.nbDeRemboursement = nbDeRemboursement;
            this.montantParRemboursement = montantParRemboursement;
        }

        public int Capital { get => capital; set => capital = value; }
        public float Taux { get => taux; set => taux = value; }
        public int NbDeRemboursement { get => nbDeRemboursement; set => nbDeRemboursement = value; }
        public double MontantParRemboursement { get => montantParRemboursement; set => montantParRemboursement = value; }


    }
}
