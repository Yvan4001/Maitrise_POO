﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.SOLID.L.Mauvais
{
    internal abstract class AppareilTransportation
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Moteur Moteur { get; set; }

        public abstract void DemarrerMoteur();
    }
}
