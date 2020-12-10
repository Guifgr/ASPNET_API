using APIRest_ASPNET5.Data.VO;
using APIRest_ASPNET5.Models;
using APIRest_ASPNET5.Models.Context;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace APIRest_ASPNET5.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MySQLContext _context;

        public EmployeeRepository(MySQLContext context)
        {
            _context = context;
        }

        public Employee ValidateCredentials(EmployeeVO employee)
        {
            var pass = ComputeHash(employee.Password, new SHA256CryptoServiceProvider());
            return _context.Employees.FirstOrDefault(e=> (e.Username == employee.Username) && (e.Password == pass));
        }

        public Employee RefreshEmployeeInfo(Employee employee)
        {
            if (!_context.Employees.Any(e => e.Id.Equals(employee.Id))) return null;

            var result = _context.Employees.SingleOrDefault(e => e.Id.Equals(employee.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(employee);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return result;
        }

        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }
    }
}