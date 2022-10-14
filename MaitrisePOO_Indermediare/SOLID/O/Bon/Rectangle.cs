using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.SOLID.O.Bon
{
    internal class Rectangle : IForme
    {
        public double Longueur { get; internal set; }
        public double Largeur { get; internal set; }

        public Rectangle() { }

        public Rectangle(double longueur, double largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public double Aire()
        {
            return Longueur * Largeur;
        }
    }
}
