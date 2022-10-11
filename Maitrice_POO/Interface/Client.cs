namespace Maitrice_POO.Interface
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public Adresse Adresse { get; set; } = new Adresse();

        public override string ToString()
        {
            return $"{Nom} {Prenom} - {Adresse}";
        }
    }
}