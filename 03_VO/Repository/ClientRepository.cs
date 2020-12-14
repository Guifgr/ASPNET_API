using APIRest_ASPNET5.Models;
using APIRest_ASPNET5.Models.Context;
using APIRest_ASPNET5.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIRest_ASPNET5.Repository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(MySQLContext context) : base(context) { }

        public Client Disable(long id)
        {
            if (!_context.Clients.Any(c => c.Id.Equals(id))) return null;
            var user = _context.Clients.SingleOrDefault(c => c.Id.Equals(id));
            if (user != null)
            {
                user.Enabled = false;
                try
                {
                    _context.Entry(user).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return user;
        }

        public List<Client> FindByName(string firstName)
        {
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                return _context.Clients.Where(c => c.Name.Contains(firstName)).ToList();
            }
            return null;
        }
    }
}