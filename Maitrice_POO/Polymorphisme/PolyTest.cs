using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maitrice_POO.Polymorphisme
{
    public class PolyTest
    {
        //ad-hoc (ou au niveau de fonction avec des GetType)
        public static void Acheter(Object obj)
        {
            if (obj is Table)
            {
                var table = (Table)obj;
            }
        }

        //Par sous-typage
        public static void Acheter(IPliable p)
        {
            p.Plier();
        }

        //Par type paramétrique
        public static void Acheter<T>(T pliable) where T : IPliable
        {
            pliable.Plier();
        }
    }
}
