using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.ChaineOfResponsability
{
    internal abstract class MembreEquipe
    {
        protected string nom;
        protected MembreEquipe sucesseur; //Pour avoir le membre suivant dans la chaine de responsabilite

        protected MembreEquipe(string nom, MembreEquipe sucesseur)
        {
            this.nom = nom;
            this.sucesseur = sucesseur;
        }

        public abstract void HandlePlainte(Plainte plainte);
    }
}
