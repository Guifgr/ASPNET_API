using APIRest_ASPNET5.Models;
using System.Collections.Generic;

namespace APIRest_ASPNET5.Repository
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        Vehicle Disable(long id);

        List<Vehicle> FindByModel(string model);
    }
}