using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using gestion_banque.entity;

namespace gestion_banque.transaction
{
    internal class GestionAgence
    {
        private List<Client> clients = new List<Client>();
        private List<Compte> comptes = new List<Compte>();

        public void AjouterClient(Client client)
        {
            if (clients.Any(c => c.getId() == client.getId()))
            {
                Console.WriteLine("ce client existe");
                return;
            }

            clients.Add(client);
            Console.WriteLine("ajout avec succes.");
        }

        public void AfficherClients()
        {
            if (clients.Count == 0)
            {
                Console.WriteLine("la liste des client est vide .");
                return;
            }

            foreach (var client in clients)
            {
                Console.WriteLine(client); 
            }
        }

        public Client ChercherClientParId(int id)
        {
            return clients.FirstOrDefault(c => c.getId() == id); 
        }

        
        public void AjouterCompte(Compte compte)
        {
            comptes.Add(compte);
            Console.WriteLine("Compte ajoute");
        }

        
        public void AfficherComptes()
        {
            if (comptes.Count == 0)
            {
                Console.WriteLine("la liste des co;pte est vide .");
                return;
            }

            foreach (var compte in comptes)
            {
                compte.afficherDetails();
            }
        }

        public Compte ChercherCompteParNumero(string numeroCompte)
        {
            return comptes.FirstOrDefault(c => c.getNumeroCompte() == numeroCompte);
        }
    }

}