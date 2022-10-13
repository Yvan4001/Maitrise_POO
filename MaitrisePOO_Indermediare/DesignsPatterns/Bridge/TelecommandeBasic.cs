using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Bridge
{
    internal class TelecommandeBasic : Telecommande
    {
        public override void ChangeVolume(int volume)
        {
            appareil.ChangeVolume(volume);
        }

        public override void ChangeCanal(int canal)
        {
            appareil.ChangeCanal(canal);
        }

        public override void OnOrOff()
        {
            if (appareil.IsAppareilEnabled())
                appareil.TurnOff();
            else
                appareil.TurnOn();
        }
    }
}
