using APIRest_ASPNET5.Models;
using System.Collections.Generic;

namespace APIRest_ASPNET5.Business
{
    public interface IVehicleBusiness
    {
        VehicleVO Create(VehicleVO vehicle);

        VehicleVO FindById(long id);

        List<VehicleVO> FindAll();

        VehicleVO Update(VehicleVO vehicle);

        void Delete(long id);
    }
}
