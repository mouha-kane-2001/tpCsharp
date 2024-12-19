using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestion_banque.entity;

namespace gestion_banque.transaction
{
    internal interface ITransaction
    {
        void Deposer(int montant);
        void Retirer(int montant);
        void Transfert(Compte compteDestination, int montant);
    }
}
