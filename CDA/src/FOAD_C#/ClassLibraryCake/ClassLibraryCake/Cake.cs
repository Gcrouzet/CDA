using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibraryCake
{
    public class Cake
    {
        decimal volumeEnPourcent;
        const decimal volumeEnPourcentMax = 120;

        public delegate void DelegateCuisson();
        public event DelegateCuisson GateauCuit;


        public Cake()
        {
            volumeEnPourcent = 10;
        }
        
        public void Cuire()
        {
            Thread t = new Thread(Gonfler);
            t.Start();
        }  
        
        private void Gonfler()
        {
            while (volumeEnPourcent < volumeEnPourcentMax)
            {

                volumeEnPourcent += 10;
                Thread.Sleep(250);

            }
            //emettre un evenement
            if (GateauCuit !=null)
            {
                GateauCuit();
            }
           
        }
    }
}
