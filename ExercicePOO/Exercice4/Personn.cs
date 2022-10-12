using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePOO.Exercice4
{
    internal class Personn
    {
        public string Nom { get; set; } = string.Empty;

        public House House { get; set; } = new House(120);
        public Personn(string nom, House house)
        {
            Nom = nom;
            House = house;
        }

        public void Display()
        {
            Console.WriteLine($"Je suis {Nom} et j'habite dans une maison de {House.Surface} m2 et ma porte est de couleur {House.GetDoor().Color}");
         }
    }
}
