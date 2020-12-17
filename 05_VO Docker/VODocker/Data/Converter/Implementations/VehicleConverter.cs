using APIRest_ASPNET5.Data.Converter.Contract;
using APIRest_ASPNET5.Data.VO;
using APIRest_ASPNET5.Models;
using System.Collections.Generic;
using System.Linq;

namespace APIRest_ASPNET5.Data.Converter.Implementations
{
    public class VehicleConverter : IParser<VehicleVO, Vehicle>, IParser<Vehicle, VehicleVO>
    {
        public Vehicle Parse(VehicleVO origin)
        {
            if (origin == null) return null;
            return new Vehicle
            {
                Id = origin.Id,
                Model = origin.Model,
                Year = origin.Year,
                Plate = origin.Plate,
                Color = origin.Color

            };
        }

        public VehicleVO Parse(Vehicle origin)
        {
            if (origin == null) return null;
            return new VehicleVO
            {
                Id = origin.Id,
                Model = origin.Model,
                Year = origin.Year,
                Plate = origin.Plate,
                Color = origin.Color
            };
        }

        public List<Vehicle> Parse(List<VehicleVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<VehicleVO> Parse(List<Vehicle> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
