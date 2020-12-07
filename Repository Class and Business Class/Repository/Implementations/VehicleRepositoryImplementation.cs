using APIRest_ASPNET5.Models;
using APIRest_ASPNET5.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIRest_ASPNET5.Repository.Implementations
{
    public class VehicleRepositoryImplementation : IVehicleRepository
    {
        private MySQLContext _context;

        public VehicleRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public List<Vehicle> FindAll()
        {
            
            return _context.Vehicles.ToList();
        }

        public Vehicle FindById(long id)
        {
            return _context.Vehicles.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Vehicle Create(Vehicle vehicle)
        {
            try
            {
                _context.Add(vehicle);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return vehicle;
        }

        public Vehicle Update(Vehicle vehicle)
        {
            if (!Exists(vehicle.Id)) return null;

            var result = _context.Vehicles.SingleOrDefault(p => p.Id.Equals(vehicle.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(vehicle);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                return vehicle;
            }

            try
            {
                _context.Add(vehicle);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return vehicle;
        }

        public void Delete(long id)
        {
            var result = _context.Vehicles.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Vehicles.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _context.Vehicles.Any(p => p.Id.Equals(id));
        }

    }
}
