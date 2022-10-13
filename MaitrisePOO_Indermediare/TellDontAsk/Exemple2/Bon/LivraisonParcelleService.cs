using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.TellDontAsk.Exemple2.Bon
{
    internal class LivraisonParcelleService
    {
        public void LivrerParcelle(long clientId)
        {
            var livreur = new Livreur();
            livreur.Livrer(clientId);
        }
    }
}
