using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.TellDontAsk.Exemple1.Bon
{
    internal class CompteService : ICompteService
    {
        private readonly CompteRepository _compteRepository;

        public CompteService(CompteRepository compteRepository)
        {
            _compteRepository = compteRepository;
        }

        public void Retrait(int idCompte, double montant)
        {
            Compte compte = _compteRepository.FindById(idCompte);

            compte.Retrait(montant);
            
            _compteRepository.Save(compte);
        }
    }
}
