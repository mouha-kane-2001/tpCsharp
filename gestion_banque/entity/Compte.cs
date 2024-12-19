using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace gestion_banque.entity
{
    internal abstract class Compte
    {
        protected String numeroCompte;
        protected double solde;
        protected String type;
        protected DateTime dateOuverture;
        protected String titulaire;
        protected String statut;
        protected Agence agence;
        public Compte(String numeroCompte,double solde, String type, DateTime dateOuverture, String titulaire, String statut, Agence agence)
        {
            this.numeroCompte = numeroCompte;
            this.solde = solde;
            this.type = type;
            this.dateOuverture = dateOuverture;
            this.titulaire = titulaire;
            this.statut = statut;
            this.agence = agence;

        }

        public double getSolde() { return solde; }
        public String getType() { return type; }
        public DateTime getDateOuverture() { return dateOuverture; }
        public String getTitulaire() { return titulaire; }
        public String getStatut() { return statut; }
        public Agence getAgence() { return agence; }

       public String getNumeroCompte() { return numeroCompte; }


        public void setSolde(int solde) { this.solde = solde; }
        public void setType(String type) { this.type = type; }
        public void setDateOuverture(DateTime dateOuverture) { this.dateOuverture = dateOuverture; }
        public void setTitulaire(String titulaire) { this.titulaire = titulaire; }
        public void setStatut(String statut) { this.statut = statut; }
        public void setAgence(Agence agence) { this.agence = agence; }
        public void setNumeroCompte(String numeroCompte) { this.numeroCompte = numeroCompte; }


        public void afficherDetails()
        {
            Console.WriteLine("NumeroCompte: " + numeroCompte);
            Console.WriteLine("Titilaire " + titulaire);
            Console.WriteLine("Agence "+ agence);
            Console.WriteLine("Statut "+ statut );
            Console.WriteLine("DateOuverture "+ dateOuverture);
            Console.WriteLine("Type"+ type);
            Console.WriteLine("Solde"+ solde);
           

        }

        public void Deposer(int montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Le montant a deposer doit etre positif");
                return;
            }
            solde += montant;
            Console.WriteLine($"depot de {montant}.franc effectue avec succes , nouveau solde : {solde}.franc ");

        }

        public void Retirer(int montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Le montant a retirer doit etre positif.");
                return;
            }
            if (montant > solde)
            {
                Console.WriteLine($"impossible de retirer {montant}: car votre solde est {solde}");
            }
            else
            {
                solde -= montant;
                Console.WriteLine($"retrait de {montant}.franc effectue avec succes , nouveau solde : {solde}.franc ");

            }
        }


        public void Transfert(Compte compteDestination, int montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Le montant a transfere  doit etre positif.");
                return;
            }
            if (montant > solde)
            {
                Console.WriteLine($"impossible de faire un transfert de  {montant}: car votre solde est {solde}");
            }
            else
            {
                this.Retirer(montant);
                compteDestination.Deposer(montant);
                Console.WriteLine($"retrait de {montant}.franc effectue avec succes , nouveau solde : {solde}.franc ");

            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
   
    }
