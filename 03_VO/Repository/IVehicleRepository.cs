using APIRest_ASPNET5.Models;

namespace APIRest_ASPNET5.Repository
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        Vehicle Disable(long id);
    }
}