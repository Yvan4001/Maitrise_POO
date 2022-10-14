using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Observer.Exemple1
{
    internal class Produit : ISujet
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        private decimal _prix;

        public decimal Prix
        {
            get { return _prix; }
            set
            {
                _prix = value;
                NotifyObserver(this);
            }
        }
        
        public List<IObservateur> Observers { get; set; }

        public Produit()
        {
            Description = string.Empty;
            Observers = new List<IObservateur>();
        }


        public void AttachObserver(IObservateur observateur)
        {
            if (!Observers.Contains(observateur))
                Observers.Add(observateur);
        }

        public void DetachObserver(IObservateur observateur)
        {
            Observers.Remove(observateur);
        }

        public void NotifyObserver(ISujet sujet)
        {
            Observers.ForEach(o => o.Update(sujet));
        }
    }
}
