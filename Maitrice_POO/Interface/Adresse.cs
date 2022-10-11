namespace Maitrice_POO.Interface
{
    public class Adresse
    {
        public int Numero { get; set; }
        public string Voie { get; set; } = string.Empty;
        public string Ville { get; set; } = string.Empty;
        public string CodePostal { get; set; } = string.Empty;
        public string Pays { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{Numero} {Voie} - {CodePostal} {Ville} - {Pays}";
        }
    }
}