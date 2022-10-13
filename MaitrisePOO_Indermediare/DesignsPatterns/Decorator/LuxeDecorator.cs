using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Decorator
{
    internal class LuxeDecorator : VoitureDecorator
    {
        public LuxeDecorator(IVoiture voiture) : base(voiture)
        {
        }
        
        public override void Assembler()
        {
            base.Assembler();
            Console.WriteLine("Ajout de sièges en cuir");
        }
    }
}
