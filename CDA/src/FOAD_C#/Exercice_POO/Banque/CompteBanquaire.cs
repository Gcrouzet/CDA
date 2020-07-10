using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class CompteBanquaire
    {
        private int id;

        private string client;

        private float solde;

        private int decouvertAutorise;


        public CompteBanquaire(int _id, string _client, float _solde, int _decouvertAutorise)
        {
            id = _id;
            client = _client;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }
        public override string ToString()
        {
            return "id : " + id + " nom : " + client + " solde : " + solde + " decouvert autorisé : " + decouvertAutorise;
        }
        public void Crediter(int nombre)
        {
            solde = solde + nombre;
        }
        public bool Debiter(int nombre)
        {
            if ((solde - nombre) < decouvertAutorise)
            {
                return false;
            }
            else
            {
                solde = solde - nombre;
                return true;
            }
        }
        public bool Transferer(int nombre, CompteBanquaire _compte)
        {
            if ((solde - nombre) < decouvertAutorise)
            {
                return false;
            }
            else
            {
                _compte.solde = _compte.solde + nombre;
                solde = solde - nombre;

                return true;
            }
        }
        public bool Superieur(CompteBanquaire _compte)
        {
            if (this.solde > _compte.solde)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
