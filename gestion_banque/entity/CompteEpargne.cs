using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_banque.entity
{
    internal class CompteEpargne : Compte
    {
        private double tauxInteret { get; set; }

        public CompteEpargne(String numeroCompte, double solde, String type, DateTime dateOuverture, String titulaire, String statut, Agence agence, double tauxInteret) : base(numeroCompte, solde, type, dateOuverture, titulaire, statut, agence)
        { this.tauxInteret = tauxInteret; }
        public void CalculInteret()
        {
            type = "Compte Epargne";
            double interet = solde * tauxInteret;
            solde += interet;
            Console.WriteLine($"  interet ajouter au solde {interet } le nouveau solde devient {solde} "  );

        }
    }
}