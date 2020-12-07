using APIRest_ASPNET5.Models;
using System.Collections.Generic;

namespace APIRest_ASPNET5.Repository
{
    public interface IVehicleRepository
    {
        Vehicle Create(Vehicle vehicle);

        Vehicle FindById(long id);

        List<Vehicle> FindAll();

        Vehicle Update(Vehicle vehicle);

        void Delete(long id);

        bool Exists(long id);
    }
}
