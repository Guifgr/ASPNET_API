using APIRest_ASPNET5.Data.VO;
using APIRest_ASPNET5.Models;

namespace APIRest_ASPNET5.Repository
{
    public interface IEmployeeRepository
    {
        Employee ValidateCredentials(EmployeeVO employee);

        Employee ValidateCredentials(string username);

        bool RevokeToken(string username);

        Employee RefreshEmployeeInfo(Employee employee);
    }
}