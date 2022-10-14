using System.Diagnostics;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Observer.Exemple2
{
    internal class Contact : IObserver<ChangementPrixEvent>
    {
        public string Nom { get; set; } = string.Empty;

        public void OnCompleted()
        {
            Debug.WriteLine("Termine ...");
        }

        public void OnError(Exception error)
        {
            Debug.WriteLine(error.Message);
        }

        public void OnNext(ChangementPrixEvent value)
        {
            Console.WriteLine(value.DateTime.ToString("dd/MM/yy") + " - " + value.MessageNofif);
        }
    }
}
