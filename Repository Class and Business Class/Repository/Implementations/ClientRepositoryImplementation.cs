using APIRest_ASPNET5.Models;
using APIRest_ASPNET5.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIRest_ASPNET5.Repository.Implementations
{
    public class ClientRepositoryImplementation : IClientRepository
    {
        private MySQLContext _context;

        public ClientRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public List<Client> FindAll()
        {
            return _context.Clients.ToList();
        }

        public Client FindById(long id)
        {
            return _context.Clients.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Client Create(Client client)
        {
            try
            {
                _context.Add(client);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return client;
        }

        public Client Update(Client client)
        {
            if (!Exists(client.Id)) return null;

            var result = _context.Clients.SingleOrDefault(p => p.Id.Equals(client.Id));
            if (result != null)
            {
                try
                 {
                    _context.Entry(result).CurrentValues.SetValues(client);
                    _context.SaveChanges();
                 }
                catch (Exception)
                 {

                    throw;
                 }
                return client;
            }

            try
            {
                _context.Add(client);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return client;
        }

        public void Delete(long id)
        {
            var result = _context.Clients.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Clients.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _context.Clients.Any(p => p.Id.Equals(id));
        }
    }
}
