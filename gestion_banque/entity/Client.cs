using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_banque.entity
{
    internal class Client
    {
        static int nbpersonnes;
        private int Id;
        private String prenom;
        private String nom;
        private String typeCompte;
        public Client(string prenom, string nom, string typeCompte)
        {
            {
                this.prenom = prenom;
                this.nom = nom;
                nbpersonnes++;
                this.Id = nbpersonnes;
                this.typeCompte = typeCompte;
                
            }
        }
    
        public String getPrenom() { return prenom; }
        public String getNom() { return nom; }
        public int getId() { return Id; }
        public String getTypeCompte() {  return typeCompte; }

        public  void setPrenom(String prenom) {  this.prenom= prenom; }
        public  void setNom(String nom) { this.nom = nom; }
        public void setTypeCompte(String typeCompte) { this.typeCompte = typeCompte; }

        public void afficherDetails()
        {
            Console.WriteLine("Identifiant  " + Id);
            Console.WriteLine("Prenom: " + prenom);
            Console.WriteLine("Nom " + nom);
            Console.WriteLine("nbpersonnes" + nbpersonnes);
            Console.WriteLine("TypeCompte" + typeCompte);

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}