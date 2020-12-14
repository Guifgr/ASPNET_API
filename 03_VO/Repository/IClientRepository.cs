using APIRest_ASPNET5.Models;
using System.Collections.Generic;

namespace APIRest_ASPNET5.Repository
{
    public interface IClientRepository : IRepository<Client>
    {
        Client Disable(long id);

        List<Client> FindByName(string firstName);
    }
}