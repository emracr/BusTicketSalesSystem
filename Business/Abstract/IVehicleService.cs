using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVehicleService
    {
        IDataResult<List<Vehicle>> GetAll();
        IDataResult<List<VehiclesDetailsDto>> GetVehiclesDetails();
        IDataResult<Vehicle> GetById(int vehicleId);
        IResult Add(Vehicle vehicle);
        IResult Update(Vehicle vehicle);
        IResult Delete(Vehicle vehicle);
    }
}
