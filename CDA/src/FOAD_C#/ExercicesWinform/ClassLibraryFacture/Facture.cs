using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFacture
{
    public class Facture
    {
        private string nom;
        private DateTime date;
        private float montant;
        private string codePostal;

        public Facture()
        {
            nom = "";
            date = DateTime.Now;
            montant = 0;
            codePostal = "00000";
        }

        public Facture(string nom, DateTime date, float montant, string codePostal)
        {
            this.nom = nom;
            this.date = date;
            this.montant = montant;
            this.codePostal = codePostal;
        }
    }
}
