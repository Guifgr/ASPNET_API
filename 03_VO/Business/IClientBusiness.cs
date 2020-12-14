using APIRest_ASPNET5.Data.VO;
using System.Collections.Generic;

namespace APIRest_ASPNET5.Business
{
    public interface IClientBusiness
    {
        ClientVO Create(ClientVO client);

        ClientVO FindById(long id);

        List<ClientVO> FindByName(string name);

        List<ClientVO> FindAll();

        ClientVO Update(ClientVO client);

        ClientVO Disable(long id);

        void Delete(long id);
    }
}