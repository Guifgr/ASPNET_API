using APIRest_ASPNET5.Models;
using APIRest_ASPNET5.Repository;
using System.Collections.Generic;

//here we can implement business rules

namespace APIRest_ASPNET5.Business.Implementations
{
    public class ClientBusinessImplementation : IClientBusiness
    {
        private readonly IRepository<Client> _repository;

        public ClientBusinessImplementation(IRepository<Client> repository)
        {
            _repository = repository;
        }

        public List<Client> FindAll()
        {
            return _repository.FindAll();
        }

        public Client FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Client Create(Client client)
        {
            return _repository.Create(client);
        }

        public Client Update(Client client)
        {
            return _repository.Update(client);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
