using APIRest_ASPNET5.Data.Converter.Implementations;
using APIRest_ASPNET5.Data.VO;
using APIRest_ASPNET5.Hypermedia.Utils;
using APIRest_ASPNET5.Repository;
using System.Collections.Generic;

//here we can implement business rules

namespace APIRest_ASPNET5.Business.Implementations
{
    public class ClientBusinessImplementation : IClientBusiness
    {
        private readonly IClientRepository _repository;
        private readonly ClientConverter _converter;

        public ClientBusinessImplementation(IClientRepository repository)
        {
            _repository = repository;
            _converter = new ClientConverter();
        }

        public ClientVO Create(ClientVO client)
        {
            var clientEntity = _converter.Parse(client);
            clientEntity = _repository.Create(clientEntity);
            return _converter.Parse(clientEntity);
        }

        public ClientVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public List<ClientVO> FindByName(string name)
        {
            return _converter.Parse(_repository.FindByName(name));
        }

        public List<ClientVO> FindWithPagedSearch()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PagedSearchVO<ClientVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page)
        {
            var sort = (!string.IsNullOrWhiteSpace(sortDirection)
                && !sortDirection.Equals("desc")) ? "asc" : "desc";

            var size = (pageSize < 1) ? 10 : pageSize;
            var offset = page > 0 ? (page - 1) * size : 0;

            string query = @"select * from client c where 1 = 1 ";
            if (!string.IsNullOrWhiteSpace(name)) query = query + $" and c.name like '%{name}%' ";
            query += $" order by c.name {sort} limit {size} offset {offset} ";

            string count = @"select count(*) from client c where 1 = 1 ";
            if (!string.IsNullOrWhiteSpace(name)) count = count + $" and c.name like '%{name}%' ";

            var clients = _repository.FindAllWithPagedSearch(query);
            int totalResults = _repository.GetCount(count);

            return new PagedSearchVO<ClientVO>
            {
                CurrentPage = page,
                List = _converter.Parse(clients),
                PageSize = size,
                SortDirections = sort,
                TotalResult = totalResults
            };
        }

        public ClientVO Update(ClientVO client)
        {
            var clientEntity = _converter.Parse(client);
            clientEntity = _repository.Update(clientEntity);
            return _converter.Parse(clientEntity);
        }
        public ClientVO Disable(long id)
        {
            var clientEntity = _repository.Disable(id);
            return _converter.Parse(clientEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}