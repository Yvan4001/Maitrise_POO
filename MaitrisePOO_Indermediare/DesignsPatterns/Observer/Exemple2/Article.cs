using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Observer.Exemple2
{
    internal class Article : IObservable<ChangementPrixEvent>
    {
        public string Description { get; set; } = string.Empty;

        private List<IObserver<ChangementPrixEvent>> _observers;

        public Article()
        {
            _observers = new List<IObserver<ChangementPrixEvent>>();
        }

        private decimal _prix;

        public decimal Prix
        {
            get => _prix;
            set
            {
                _prix = value;
                var evt = new ChangementPrixEvent(DateTime.Now, "Changement de prix de l'article " + Description + " à " + Prix);

                _observers.ForEach(o => o.OnNext(evt));
            }
        }

        public IDisposable Subscribe(IObserver<ChangementPrixEvent> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);

            return new UnSubscriber(_observers, observer);
        }
    }
}