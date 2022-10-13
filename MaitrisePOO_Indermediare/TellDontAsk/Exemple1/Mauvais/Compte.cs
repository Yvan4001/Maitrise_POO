using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.TellDontAsk.Exemple1.Mauvais
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
    }
}
