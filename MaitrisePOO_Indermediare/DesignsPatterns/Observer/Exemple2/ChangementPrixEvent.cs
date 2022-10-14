using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Observer.Exemple2
{
    internal class ChangementPrixEvent
    {
        public DateTime DateTime { get; set; }
        public string MessageNofif { get; set; }

        public ChangementPrixEvent(DateTime dateTime, string messageNofif)
        {
            DateTime = dateTime;
            MessageNofif = messageNofif;
        }
    }
}
