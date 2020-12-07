using APIRest_ASPNET5.Models;
using System.Collections.Generic;

namespace APIRest_ASPNET5.Business
{
    public interface IVehicleBusiness
    {
        Vehicle Create(Vehicle vehicle);

        Vehicle FindById(long id);

        List<Vehicle> FindAll();

        Vehicle Update(Vehicle vehicle);

        void Delete(long id);
    }
}
