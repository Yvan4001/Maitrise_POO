using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.ChaineOfResponsability
{
    internal class Formateur : MembreEquipe
    {
        public Formateur(string nom, MembreEquipe sucesseur) : base(nom, sucesseur)
        {
        }

        public override void HandlePlainte(Plainte plainte)
        {
            if (plainte.TypePlainte == Types.Formateur)
            {
                Console.WriteLine("Le formateur " + nom + " a pris en charge la plainte");
                plainte.EtatPlainte = Etats.Fermee;
            }
            else if (sucesseur != null)
            {
                Console.WriteLine("Le formateur " + nom + " n'a pas pris en charge la plainte");
                sucesseur.HandlePlainte(plainte);
            }
        }
    }
}
