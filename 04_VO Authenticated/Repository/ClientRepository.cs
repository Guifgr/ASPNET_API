using APIRest_ASPNET5.Models;
using APIRest_ASPNET5.Models.Context;
using APIRest_ASPNET5.Repository.Generic;
using System;
using System.Linq;

namespace APIRest_ASPNET5.Repository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(MySQLContext context) : base(context) { }

        public Client Disable(long id)
        {
            if (!_context.Clients.Any(c => c.Id.Equals(id))) return null;
            var client = _context.Clients.SingleOrDefault(c => c.Id.Equals(id));
            if (client != null)
            {
                client.Enabled = false;
                try
                {
                    _context.Entry(client).CurrentValues.SetValues(client);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return client;
        }
    }
}