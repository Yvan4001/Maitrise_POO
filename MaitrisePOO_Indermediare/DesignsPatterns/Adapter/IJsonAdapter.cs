using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaitrisePOO_Intermediaire.DesignsPatterns.Adapter
{
    internal interface IJsonAdapter
    {
        string RecupContactsJson(string path);
    }
}
