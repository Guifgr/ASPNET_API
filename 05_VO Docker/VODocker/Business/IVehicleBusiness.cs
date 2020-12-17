using APIRest_ASPNET5.Data.VO;
using System.Collections.Generic;

namespace APIRest_ASPNET5.Business
{
    public interface IVehicleBusiness
    {
        VehicleVO Create(VehicleVO vehicle);

        VehicleVO FindById(long id);

        List<VehicleVO> FindByModel(string model);

        List<VehicleVO> FindAll();

        VehicleVO Update(VehicleVO vehicle);

        VehicleVO Disable(long id);

        void Delete(long id);
    }
}