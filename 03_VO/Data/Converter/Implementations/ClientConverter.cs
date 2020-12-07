using APIRest_ASPNET5.Data.Converter.Contract;
using APIRest_ASPNET5.Data.VO;
using APIRest_ASPNET5.Models;
using System.Collections.Generic;
using System.Linq;

namespace APIRest_ASPNET5.Data.Converter.Implementations
{
    public class ClientConverter : IParser<ClientVO, Client>, IParser<Client, ClientVO>
    {
        public Client Parse(ClientVO origin)
        {
            if (origin == null) return null;
            return new Client
            {
                Id = origin.Id,
                Name = origin.Name,
                CNH = origin.CNH,
                Age = origin.Age,
                Gender = origin.Gender

            };
        }

        public ClientVO Parse(Client origin)
        {
            if (origin == null) return null;
            return new ClientVO
            {
                Id = origin.Id,
                Name = origin.Name,
                CNH = origin.CNH,
                Age = origin.Age,
                Gender = origin.Gender
            };
        }

        public List<Client> Parse(List<ClientVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<ClientVO> Parse(List<Client> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
