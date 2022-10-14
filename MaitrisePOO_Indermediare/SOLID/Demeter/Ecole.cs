using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.SOLID.Demeter
{
    internal class Ecole
    {
        private List<Grade> _grades;

        /*//cette méthode qui ne respecte pas la loin Demeter
        public int CompterEtudiant()
        {
            int nombreEtudiant = 0;
            foreach (var grade in _grades)
            {
                foreach (var classe in grade.Classes)
                {
                    foreach (var etudiant in classe.Etudiants)
                    {
                        nombreEtudiant++;
                    }
                }
            }

            return nombreEtudiant;
        }*/

        public int CompterEtudiant()
        {
            int total = 0;
            _grades.ForEach(g => total = g.CompterEtudiant());
            return total;
        }
    }
}
