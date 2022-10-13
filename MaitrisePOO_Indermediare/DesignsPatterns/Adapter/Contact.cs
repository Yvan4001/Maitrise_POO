﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Adapter
{
    [DataContract]
    internal class Contact
    {
        [DataMember] public int Id { get; set; }
        [DataMember] public string Nom { get; set; } = string.Empty;
    }
}
