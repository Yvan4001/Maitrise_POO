using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.TellDontAsk.Exemple1.Bon
{
    internal interface ICompteRepository
    {
        Compte FindById(int id);
        void Save(Compte compte);
    }
}
