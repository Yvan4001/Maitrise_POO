using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Bridge
{
    internal abstract class Telecommande
    {
        protected IAppareil appareil;

        public void DefineDefice(IAppareil appareil) { this.appareil = appareil; }
        
        public abstract void ChangeVolume(int volume);
        public abstract void ChangeCanal(int canal);
        public abstract void OnOrOff();

    }
}
