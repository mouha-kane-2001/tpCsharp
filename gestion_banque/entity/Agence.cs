using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_banque.entity
{
    internal class Agence
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public List<Compte> Comptes { get; set; }

        public Agence(string nom, string adresse)
        {
            Nom = nom;
            Adresse = adresse;
            Comptes = new List<Compte>(); 
        }

        public void AjouterCompte(Compte compte)
        {
            Comptes.Add(compte);
        }

        public void AfficherDetails()
        {
            Console.WriteLine($"Nom de l'agence: {Nom}");
            Console.WriteLine($"Adresse: {Adresse}");
            Console.WriteLine($"Nombre de comptes: {Comptes.Count}");
        }
    }
}
