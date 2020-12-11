using APIRest_ASPNET5.Data.VO;

namespace APIRest_ASPNET5.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(EmployeeVO employee);

        TokenVO ValidateCredentials(TokenVO token);
    }
}