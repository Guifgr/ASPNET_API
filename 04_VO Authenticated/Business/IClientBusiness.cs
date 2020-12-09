using APIRest_ASPNET5.Data.VO;
using System.Collections.Generic;

namespace APIRest_ASPNET5.Business
{
    public interface IClientBusiness
    {
        ClientVO Create(ClientVO client);

        ClientVO FindById(long id);

        List<ClientVO> FindAll();

        ClientVO Update(ClientVO client);

        void Delete(long id);
    }
}