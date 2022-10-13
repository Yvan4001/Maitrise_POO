using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Decorator
{
    internal class VoitureBasic : IVoiture
    {
        public void Assembler()
        {
            Console.WriteLine("Voiture basique");
        }
    }
}
