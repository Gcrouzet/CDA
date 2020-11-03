using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPret
{
    public class Pret
    {
        private float capitalEmprunt;
        private double tauxEnPourcentage;
        private int dureeRemboursementEnMois;
        private Periodicite periodicite;


        public Pret()
        {
            this.capitalEmprunt = 0;
            this.DureeRemboursementEnMois = 1;
            this.Periodicite = Periodicite.Mensuelle;
            this.tauxEnPourcentage = 7;

        }

        public Pret(float capitalEmprunt, int tauxEnPourcentage, int dureeRemboursementEnMois, Periodicite periodicite)
        {
            this.capitalEmprunt = capitalEmprunt;
            this.tauxEnPourcentage = tauxEnPourcentage;
            this.dureeRemboursementEnMois = dureeRemboursementEnMois;
            this.periodicite = periodicite;
        }

        public float CapitalEmprunt { get => capitalEmprunt; set => capitalEmprunt = value; }
        public double TauxEnPourcentage { get => tauxEnPourcentage; set => tauxEnPourcentage = value; }
        public int DureeRemboursementEnMois { get => dureeRemboursementEnMois; set => dureeRemboursementEnMois = value; }
        public Periodicite Periodicite { get => periodicite; set => periodicite = value; }

        public int CalculNombreDeRemboursement()
        {

            return dureeRemboursementEnMois / Convert.ToInt32(periodicite);

        }
        public double CalculMontantEcheance()
        {

            int nbRemboursement = CalculNombreDeRemboursement();
            double tauxPeriodicite = tauxEnPourcentage / (12 / Convert.ToInt32(periodicite)) / 100;
            return capitalEmprunt * (tauxPeriodicite / (1 - Math.Pow(1 + tauxPeriodicite, -nbRemboursement)));

        }
    }
}
