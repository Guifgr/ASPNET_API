using APIRest_ASPNET5.Models;
using APIRest_ASPNET5.Repository;
using System.Collections.Generic;

//here we can implement business rules

namespace APIRest_ASPNET5.Business.Implementations
{
    public class VehicleBusinessImplementation : IVehicleBusiness
    {
        private readonly IRepository<Vehicle> _repository;

        public VehicleBusinessImplementation(IRepository<Vehicle> repository)
        {
            _repository = repository;
        }

        public List<Vehicle> FindAll()
        {
            return _repository.FindAll();
        }

        public Vehicle FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Vehicle Create(Vehicle vehicle)
        {
            return _repository.Create(vehicle);
        }

        public Vehicle Update(Vehicle vehicle)
        {
            return _repository.Update(vehicle);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
