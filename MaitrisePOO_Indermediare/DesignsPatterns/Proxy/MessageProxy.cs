using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Proxy
{
    internal class MessageProxy : IMessage
    {
        private IMessage _messageProxyfie;

        public MessageProxy(IMessage messageProxyfie)
        {
            _messageProxyfie = messageProxyfie;
        }

        string IMessage.RecupContent()
        {
            var content = _messageProxyfie.RecupContent();

            //Faire des vérification ou transformation 

            string contentTransforme = content.ToUpper();
            
            return contentTransforme;
        }
    }
}
