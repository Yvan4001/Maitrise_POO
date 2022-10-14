using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.SOLID.O.Mauvais
{
    internal class CalculAire
    {
        //Open-Closed :
        //Ouvert pour l'extension,
        //Fermé la pour modification (=> Non, car à chaque ajout d'une nouvelle forme)
        //On devrait ajouter une nouvelle méthode pour calculer l'aire d'une nouvelle forme
        public double CalculerAire(Rectangle r)
        {
            return r.Longueur * r.Largeur;
        }

        public double CalculerAire(Cercle c)
        {
            return Math.PI * Math.Pow(c.Rayon, 2);
        }
    }
}
