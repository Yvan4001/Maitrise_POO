﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.TellDontAsk.Exemple2.Bon
{
    internal class Client
    {
        public long Id { get; internal set; }
        public string AdresseClient { get; internal set; }

        public List<Parcelle> parcelles { get; internal set; }

        
    }
}
