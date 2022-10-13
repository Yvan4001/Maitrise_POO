using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Adapter
{
    internal interface IContactRepository
    {
        string RecupContactsXML(string path);
        List<Contact> ConvertToXML(string xml);
    }
}
