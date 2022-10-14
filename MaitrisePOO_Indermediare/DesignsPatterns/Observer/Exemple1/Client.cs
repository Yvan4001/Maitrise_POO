using System.Net;
using System.Net.Mail;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Observer.Exemple1
{
    internal class Client : IObservateur
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public Client(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override bool Equals(object? obj)
        {
            return obj is Client client &&
                   Id == client.Id;
        }

        public void Update(ISujet sujet)
        {
            Produit produit = (Produit)sujet;

            var corpsEmail = "Bonjour :\n Le produit " + produit.Description + " a changé de prix : " + produit.Prix;
            var m = new MailMessage("noreply@dawan.fr",
                Email,
                "Changement de prix du produit " + produit.Description,
                corpsEmail);

            //var client = new SmtpClient(Constante.SERVEUR_SMTP);
            //client.Credentials = CredentialCache.DefaultNetworkCredentials;
            //client.Send(m);

            Console.WriteLine(m.Body);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
