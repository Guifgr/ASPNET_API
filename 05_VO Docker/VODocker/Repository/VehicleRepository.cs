using APIRest_ASPNET5.Models;
using APIRest_ASPNET5.Models.Context;
using APIRest_ASPNET5.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIRest_ASPNET5.Repository
{
    public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(MySQLContext context) : base(context) { }

        public Vehicle Disable(long id)
        {
            if (!_context.Vehicles.Any(v => v.Id.Equals(id))) return null;
            var car = _context.Vehicles.SingleOrDefault(v => v.Id.Equals(id));
            if (car != null)
            {
                car.Enabled = false;
                try
                {
                    _context.Entry(car).CurrentValues.SetValues(car);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return car;
        }
        public List<Vehicle> FindByModel(string model)
        {
            if (!string.IsNullOrWhiteSpace(model))
            {
                return _context.Vehicles.Where(v => v.Model.Contains(model)).ToList();
            }
            return null;
        }
    }
}