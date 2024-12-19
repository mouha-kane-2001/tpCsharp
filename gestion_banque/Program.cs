using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestion_banque.entity;
using gestion_banque.transaction;

namespace gestion_banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionAgence gestion = new GestionAgence();

            while (true)
            {
                Console.Clear();  
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("1. Ajouter un client");
                Console.WriteLine("2. Afficher tous les clients");
                Console.WriteLine("3. Ajouter un compte");
                Console.WriteLine("4. Afficher tous les comptes");
                Console.WriteLine("5. Rechercher un client");
                Console.WriteLine("6. Rechercher un compte");
                Console.WriteLine("7. Quitter");
                Console.Write("Entrez votre choix (1-7): ");

                int choix;
                if (int.TryParse(Console.ReadLine(), out choix))
                {
                    switch (choix)
                    {
                        case 1:
                            AjouterClient(gestion);
                            break;
                        case 2:
                            gestion.AfficherClients();
                            break;
                            AjouterCompte(gestion);
                            break;
                        case 4:
                            gestion.AfficherComptes();
                            break;
                        case 5:
                            RechercherClient(gestion);
                            break;
                        case 6:
                            RechercherCompte(gestion);
                            break;
                        case 7:
                            Console.WriteLine("Au revoir !");
                            return;
                        default:
                            Console.WriteLine("Choix invalide. Veuillez entrer un nombre entre 1 et 7.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
                }

            }
        }

        static void AjouterClient(GestionAgence gestion)
        {
            Console.WriteLine("\n--- Ajouter un client ---");
            Console.Write("Nom : ");
            string nom = Console.ReadLine();
            Console.Write("Prénom : ");
            string prenom = Console.ReadLine();

            Client client = new Client("nom", "prenom", "Compte Simple");
            gestion.AjouterClient(client);
        }

        static void AjouterCompte(GestionAgence gestion)
        {
            Console.WriteLine("\n--- Ajouter un compte ---");
            Console.Write("Numéro de compte : ");
            string numeroCompte = Console.ReadLine();
            Console.Write("Solde initial : ");
            double soldeInitial = double.Parse(Console.ReadLine());
            Console.Write("Type de compte (Simple/Epargne) : ");
            string typeCompte = Console.ReadLine();
            Console.Write("Nom du titulaire : ");
            string titulaire = Console.ReadLine();

            Agence agence = new Agence(); 

            Compte compte;
            if (typeCompte.ToLower() == "Compte simple")
            {
                compte = new CompteSimple(numeroCompte, soldeInitial, "Compte Simple", DateTime.Now, titulaire, "Actif", agence);
            }
            else
            {
                compte = new CompteEpargne(numeroCompte, soldeInitial, "Compte Epargne", DateTime.Now, titulaire, "Actif", agence, 0.05);
            }

            gestion.AjouterCompte(compte);
        }

        static void RechercherClient(GestionAgence gestion)
        {
            Console.WriteLine("\n--- Rechercher un client ---");
            Console.Write("Entrez l'ID du client : ");
            int idClient = int.Parse(Console.ReadLine());

            Client client = gestion.ChercherClientParId(idClient);
            if (client != null)
            {
                Console.WriteLine($"\nClient trouvé : {client}");
            }
            else
            {
                Console.WriteLine("\nClient non trouvé.");
            }
        }

        static void RechercherCompte(GestionAgence gestion)
        {
            Console.WriteLine("\n--- Rechercher un compte ---");
            Console.Write("Entrez le numéro du compte : ");
            string numeroCompte = Console.ReadLine();

            Compte compte = gestion.ChercherCompteParNumero(numeroCompte);
            if (compte != null)
            {
                Console.WriteLine("\nCompte trouvé :");
                compte.afficherDetails();
            }
            else
            {
                Console.WriteLine("\nCompte non trouvé");
            }
        }
    }
   
}
   