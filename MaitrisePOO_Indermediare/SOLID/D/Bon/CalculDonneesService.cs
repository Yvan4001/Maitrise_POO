using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.SOLID.D.Bon
{
    internal class CalculDonneesService
    {
        private readonly IUtilisateurRepository _utilisateurRepository;

        public CalculDonneesService(IUtilisateurRepository utilisateurRepository)
        {
            _utilisateurRepository = utilisateurRepository;
        }

        public object CalculPourUtilisateur(long id)
        {
            var u = _utilisateurRepository.FindById(id);
            //Traitement
            return null; //Retourne le resultat
        }
    }
}
