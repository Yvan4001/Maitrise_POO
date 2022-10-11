using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maitrice_POO.Polymorphisme
{
    public class Table : IPliable
    {
        string IPliable.Deplier()
        {
            throw new NotImplementedException();
        }

        string IPliable.Plier()
        {
            throw new NotImplementedException();
        }
    }
}
