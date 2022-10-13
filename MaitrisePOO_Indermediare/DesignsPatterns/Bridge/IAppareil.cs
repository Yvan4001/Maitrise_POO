using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Bridge
{
    internal interface IAppareil
    {
        bool IsAppareilEnabled();

        void ChangeVolume(int volume);

        void ChangeCanal(int canal);

        void TurnOn();

        void TurnOff();
    }
}
