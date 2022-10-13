using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.TellDontAsk.Exemple1.Bon
{
    internal interface ICompteService
    {
        void Retrait(int idCompte, double montant);
    }
}
