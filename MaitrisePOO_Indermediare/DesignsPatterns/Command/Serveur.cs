namespace MaitrisePOO_Intermediaire.DesignsPatterns.Command
{
    internal class Serveur //Invocker
    {

        public void TakeCommande(ICommander commande)
        {
            commande.Execute();
        }
    }
}
