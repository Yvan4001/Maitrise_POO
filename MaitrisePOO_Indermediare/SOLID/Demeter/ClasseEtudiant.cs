﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.SOLID.Demeter
{
    internal class ClasseEtudiant
    {
        public IList<Etudiant> Etudiants { get; internal set; }

        public int CompterEdutiant() => Etudiants.Count;
    }
}
