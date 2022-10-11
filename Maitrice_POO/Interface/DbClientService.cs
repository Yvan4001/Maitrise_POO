using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maitrice_POO.Interface
{
    public class DbClientService : IClient
    {
        void IClient.AddClient(Client client)
        {
            throw new NotImplementedException();
        }

        void IClient.DeleteClient(Client client)
        {
            throw new NotImplementedException();
        }

        List<Client> IClient.GetClient(Client client)
        {
            throw new NotImplementedException();
        }

        void IClient.UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
