using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Observer.Exemple2
{
    internal class UnSubscriber : IDisposable
    {
        private List<IObserver<ChangementPrixEvent>> _observers;
        private IObserver<ChangementPrixEvent> _observer;

        public UnSubscriber(List<IObserver<ChangementPrixEvent>> observers, IObserver<ChangementPrixEvent> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if(_observers != null)
                _observers.Remove(_observer);
        }
    }
}
