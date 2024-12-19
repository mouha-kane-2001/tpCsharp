using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestion_banque.transaction;

namespace gestion_banque.entity
{
    internal class CompteSimple : Compte
    {

        public CompteSimple(String numeroCompte, double solde, String type, DateTime dateOuverture, String titulaire, String statut, Agence agence) : base(numeroCompte, solde, type, dateOuverture, titulaire, statut, agence)
        {
            type = "Compte Simple";
        }


        
    }

}
