using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Proxy
{
    internal class MessageUtilisateur : IMessage
    {
        private string _content;

        public MessageUtilisateur(string content)
        {
            _content = content;
        }

        string IMessage.RecupContent() => _content;
    }
}
