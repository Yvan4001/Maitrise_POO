using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Bridge
{
    internal class Radio : IAppareil
    {
        void IAppareil.ChangeCanal(int canal)
        {
            throw new NotImplementedException();
        }

        void IAppareil.ChangeVolume(int volume)
        {
            throw new NotImplementedException();
        }

        bool IAppareil.IsAppareilEnabled()
        {
            throw new NotImplementedException();
        }

        void IAppareil.TurnOff()
        {
            throw new NotImplementedException();
        }

        void IAppareil.TurnOn()
        {
            throw new NotImplementedException();
        }
    }
}
