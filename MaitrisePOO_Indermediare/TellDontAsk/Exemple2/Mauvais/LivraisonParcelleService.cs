using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.TellDontAsk.Exemple2.Mauvais
{
    internal class LivraisonParcelleService
    {
        public void LivrerParcelle(long clientId)
        {
            var client = ClientDAO.FindById(clientId);

            List<Parcelle> parcelles = ParcelleDAO.FindByClientId(clientId);

            foreach (var parcelle in parcelles)
            {
                Console.WriteLine("Livraison effectue à "  + client.AdresseClient);
            }
        }
    }
}
