using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTemp
{
    public class Temperature
    {

        private float temperature;

        public delegate void DelegateTempF();
        public event DelegateTempF Fievre;

        public delegate void DelegateTempG();
        public event DelegateTempG Gel;
        public Temperature()
        {
            this.temperature = 20;
        }

        /// <summary>
        /// evenement qui se produit qd risque de gel 0 --- Gel
        /// evenement qui se produit qd on a de la fievre 38--- Fievre
        /// 
        /// 
        /// Cerise sur le gateau:
        /// 
        /// evenement preconfigurable...evenement declenche pour une temperature specifique
        private float[] temperatureDAlertes;
        /// </summary>

        public void Monter()
        {
            temperature++;
            if (temperature == 38)
            {
                if (Fievre != null) 
                {
                    Fievre();
                }
            }

        }

        public void Diminuer()
        {
            temperature--;
            if (temperature == 0)
            {
                if (Gel != null)
                {
                    Gel();
                }
            }
        }


    }
}
