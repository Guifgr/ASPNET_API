using APIRest_ASPNET5.Models;

namespace APIRest_ASPNET5.Repository
{
    public interface IClientRepository : IRepository<Client>
    {
        Client Disable(long id);
    }
}