using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.TellDontAsk.Exemple1.Bon
{
    internal class Compte
    {
        public int Id { get; set; }
        public double Solde { get; set; }

        public Compte(int id, double solde)
        {
            Id = id;
            Solde = solde;
        }
        
        public void Retrait(double montant)
        {
            if (Solde < montant)
                throw new ArgumentException("Erreur: Solde insuffisant");

            Solde -= montant;
        }
    }
}
