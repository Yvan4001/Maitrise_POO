using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.SOLID.L.Bon
{
    internal abstract class AppareilTransportationAvecMoteur : AppareilTransportation
    {
        public Moteur Moteur { get; set; }

        protected AppareilTransportationAvecMoteur(Moteur moteur)
        {
            Moteur = moteur;
        }

        public override void Bouger()
        {
            throw new NotImplementedException();
        }
    }
}
