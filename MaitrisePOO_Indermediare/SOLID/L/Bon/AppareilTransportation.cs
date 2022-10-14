using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.SOLID.L.Bon
{
    internal abstract class AppareilTransportation
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public abstract void Bouger();
    }
}
