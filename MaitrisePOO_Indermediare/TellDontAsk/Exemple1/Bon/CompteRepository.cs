using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.TellDontAsk.Exemple1.Bon
{
    internal class CompteRepository : ICompteRepository
    {
        public Compte FindById(int id)
        {
            return null;
        }

        public void Save(Compte compte)
        {
            //Requête SQL pour sauvegarder le compte
        }
    }
}
