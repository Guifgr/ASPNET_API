using APIRest_ASPNET5.Data.VO;
using APIRest_ASPNET5.Models;

namespace APIRest_ASPNET5.Repository
{
    public interface IEmployeeRepository
    {
        Employee ValidateCredentials(EmployeeVO employee);
    }
}