using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.ChaineOfResponsability
{
    internal class DirPedagogie : MembreEquipe
    {
        public DirPedagogie(string nom, MembreEquipe sucesseur) : base(nom, sucesseur)
        {
        }
        
        public override void HandlePlainte(Plainte plainte)
        {
            if (plainte.TypePlainte == Types.DirPeda)
            {
                Console.WriteLine("Le directeur pedagogique " + nom + " a pris en charge la plainte");
                plainte.EtatPlainte = Etats.Fermee;
            }
            else if (sucesseur != null)
            {
                Console.WriteLine("Le directeur pedagogique " + nom + " n'a pas pris en charge la plainte");
                sucesseur.HandlePlainte(plainte);
            }
        }
    }
}
