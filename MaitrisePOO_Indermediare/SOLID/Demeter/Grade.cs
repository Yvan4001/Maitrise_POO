using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.SOLID.Demeter
{
    internal class Grade
    {
        public IList<ClasseEtudiant> Classes { get; internal set; }

        public int CompterEtudiant()
        {
            int total = 0;
            foreach (var classe in Classes)
            {
                total += classe.CompterEdutiant();
            }
            return total;
        }
    }
}
