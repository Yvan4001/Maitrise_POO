using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Bridge
{
    internal class TelecommandeAvance : TelecommandeBasic
    {
        public void Muet()
        {
            base.ChangeVolume(0); 
        }
    }
}
