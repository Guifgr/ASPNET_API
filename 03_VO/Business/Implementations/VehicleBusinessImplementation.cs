﻿using APIRest_ASPNET5.Data.Converter.Implementations;
using APIRest_ASPNET5.Data.VO;
using APIRest_ASPNET5.Models;
using APIRest_ASPNET5.Repository;
using System.Collections.Generic;

//here we can implement business rules

namespace APIRest_ASPNET5.Business.Implementations
{
    public class VehicleBusinessImplementation : IVehicleBusiness
    {
        private readonly IVehicleRepository _repository;
        private readonly VehicleConverter _converter;

        public VehicleBusinessImplementation(IVehicleRepository repository)
        {
            _repository = repository;
            _converter = new VehicleConverter();
        }

        public List<VehicleVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public VehicleVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }
        public List<VehicleVO> FindByModel(string model)
        {
            return _converter.Parse(_repository.FindByModel(model));
        }

        public VehicleVO Create(VehicleVO vehicle)
        {
            var vehicleEntity = _converter.Parse(vehicle);
            vehicleEntity = _repository.Create(vehicleEntity);
            return _converter.Parse(vehicleEntity);
        }

        public VehicleVO Update(VehicleVO vehicle)
        {
            var vehicleEntity = _converter.Parse(vehicle);
            vehicleEntity = _repository.Update(vehicleEntity);
            return _converter.Parse(vehicleEntity);
        }
        public VehicleVO Disable(long id)
        {
            var vehicleEntity = _repository.Disable(id);
            return _converter.Parse(vehicleEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}