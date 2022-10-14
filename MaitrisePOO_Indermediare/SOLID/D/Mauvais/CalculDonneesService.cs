using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.SOLID.D.Mauvais
{
    internal class CalculDonneesService
    {
        public object CalculPourUtilisateur(long id)
        {
            UtilisateurRepository utilisateur = new UtilisateurRepository();
            var u = utilisateur.FindById(id);
            //Traitement
            return null; //Retourne le resultat
        }
    }
}
