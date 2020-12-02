using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibraryProduction
{
    public class ProductionDeCaisses
    {
        Random rand = new Random();
        private int nbCaissesDepuisDemarrage;
        private Statut statutProduction;
        private int nbCaissesAProduire;
        private int nbCaissesAProduireParHeure;
        private int i;

        public delegate void DelegateProduction(ProductionDeCaisses production);
        public event DelegateProduction ChangementNbCaisses;

        public ProductionDeCaisses(int nbCaissesAProduire, int nbCaissesAProduireParHeure)
        {
            this.nbCaissesDepuisDemarrage = 0;
            this.statutProduction = Statut.NonDemarrer;
            this.nbCaissesAProduire = nbCaissesAProduire;
            this.nbCaissesAProduireParHeure = nbCaissesAProduireParHeure;
        }
        #region set/get
        public int NbCaissesDepuisDemarrage 
        { 
            get => nbCaissesDepuisDemarrage; 
            //set => nbCaissesDepuisDemarrage = value; 
        }
        
        public int NbCaissesAProduire 
        { 
            get => nbCaissesAProduire; 
            //set => nbCaissesAProduire = value; 
        }
        
        public int NbCaissesAProduireParHeure 
        { 
            get => nbCaissesAProduireParHeure; 
            //set => nbCaissesAProduireParHeure = value; 
        }
        public Statut StatutProduction 
        {
            get => statutProduction; 
            //set => statutProduction = value; 
        }
       

        #endregion

        #region Méthode
        public int CalculBoiteDefaut()
        {
            
            if (statutProduction == Statut.Demarrer)
            {
               i +=  (int)(Math.Round(rand.NextDouble() * nbCaissesAProduireParHeure)) / 10;
            }
            return i;
        }

        public double CalculTauxDefautParHeure()
        {
          return  rand.NextDouble();
        }

        public void ThreadProd()
        {
            bool continuerThread = true;
            while (continuerThread)
            {
                if(statutProduction == Statut.Demarrer)
                {

                    Thread.Sleep(1000);
                    ProduireCaisse();
                    
                }
            else
                {
                    continuerThread = false;
                }
            }

        }

        public void ProduireCaisse()
        {
            if (!ProductionTermine())
            {
               nbCaissesDepuisDemarrage += nbCaissesAProduireParHeure;
               ChangementNbCaisses(this);
            }
        }
 
        public bool ProductionTermine()
        {
            if (this.nbCaissesDepuisDemarrage == this.nbCaissesAProduire)
            {
                statutProduction = Statut.Terminer;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangementProduction()
        {
            Thread a = new Thread(ThreadProd);

            if (statutProduction==Statut.NonDemarrer|| statutProduction == Statut.Suspendre|| statutProduction == Statut.Terminer)
            {
                statutProduction = Statut.Demarrer;
                a.Start();
                return true;
            }
            else 
            {
                return false;
            } 
        }

        public bool ArreterProduction()
        {
            if (statutProduction == Statut.Demarrer)
            {
                statutProduction = Statut.Suspendre;
               
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }

}
