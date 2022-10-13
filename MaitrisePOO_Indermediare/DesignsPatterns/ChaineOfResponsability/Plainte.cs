using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.ChaineOfResponsability
{
    public enum Types
    {
        Formateur = 1,
        DirPeda = 2,
        Directeur = 3
    }

    public enum Etats
    {
        Ouvert = 1,
        Fermee = 2
    }

    internal class Plainte
    {
        public int NumStagiaire { get; set; }

        public Types TypePlainte { get; set; }

        public string? Message { get; set; }

        public Etats EtatPlainte { get; set; }

        public Plainte(int numStagiaire, Types typePlainte, string? message, Etats etatPlainte)
        {
            NumStagiaire = numStagiaire;
            TypePlainte = typePlainte;
            Message = message;
            EtatPlainte = etatPlainte;
        }
    }
}
