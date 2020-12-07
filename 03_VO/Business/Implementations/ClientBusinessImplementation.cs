using APIRest_ASPNET5.Data.Converter.Implementations;
using APIRest_ASPNET5.Data.VO;
using APIRest_ASPNET5.Models;
using APIRest_ASPNET5.Repository;
using System.Collections.Generic;

//here we can implement business rules

namespace APIRest_ASPNET5.Business.Implementations
{
    public class ClientBusinessImplementation : IClientBusiness
    {
        private readonly IRepository<Client> _repository;
        private readonly ClientConverter _converter;

        public ClientBusinessImplementation(IRepository<Client> repository)
        {
            _repository = repository;
            _converter = new ClientConverter();
        }

        public List<ClientVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public ClientVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public ClientVO Create(ClientVO client)
        {
            var clientEntity = _converter.Parse(client);
            clientEntity = _repository.Create(clientEntity);
            return _converter.Parse(clientEntity);
        }

        public ClientVO Update(ClientVO client)
        {
            var clientEntity = _converter.Parse(client);
            clientEntity = _repository.Update(clientEntity);
            return _converter.Parse(clientEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
