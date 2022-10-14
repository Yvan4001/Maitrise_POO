using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.SOLID.O.Bon
{
    internal class CalculAire
    {
        public double CalculerAire(IForme forme)
        {
            return forme.Aire();
        }
    }
}
