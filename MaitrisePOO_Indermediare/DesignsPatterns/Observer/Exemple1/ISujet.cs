using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Observer.Exemple1
{
    internal interface ISujet
    {
        void AttachObserver(IObservateur observateur);
        void DetachObserver(IObservateur observateur);
        void NotifyObserver(ISujet sujet);
    }
}
