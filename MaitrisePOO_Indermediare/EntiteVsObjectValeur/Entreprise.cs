using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.EntiteVsObjectValeur
{
    internal class Entreprise : IComparable<Entreprise>
    {
        public int? Id { get; set; }
        public string Nom { get; set; }

        public GeoLocation Localisation { get; set; }

        public Entreprise(int? id, string nom, GeoLocation localisation)
        {
            Id = id;
            Nom = nom;
            Localisation = localisation;
        }

        public int CompareTo(Entreprise other)
        {
            return Nom.CompareTo(other.Nom);
        }

        public int CompareToLocalisation(Entreprise other)
        {
            return Localisation.CompareTo(other.Localisation);
        }

        public override bool Equals(object obj)
        {
            return obj is Entreprise entreprise &&
                   Id == entreprise.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
