using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Decorator
{
    internal class VoitureDecorator : IVoiture
    {
        protected IVoiture voiture;

        public VoitureDecorator(IVoiture voiture)
        {
            this.voiture = voiture;
        }

        public virtual void Assembler()
        {
            voiture.Assembler();
        }
    }
}
