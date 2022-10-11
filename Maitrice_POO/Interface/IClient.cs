namespace Maitrice_POO.Interface
{
    public interface IClient
    {
        void AddClient(Client client);

        void DeleteClient(Client client);

        void UpdateClient(Client client);

        List<Client> GetClient(Client client);
    }
}
