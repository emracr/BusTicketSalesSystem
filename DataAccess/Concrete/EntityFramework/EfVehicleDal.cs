using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfVehicleDal : EfEntityRepositoryBase<Vehicle, BusTicketSalesContext>, IVehicleDal
    {
        public List<VehiclesDetailsDto> GetVehiclesDetails()
        {
            using (BusTicketSalesContext context = new BusTicketSalesContext())
            {
                var result = from v in context.Vehicles
                             join ch in context.Chauffeurs
                             on v.ChauffeurId equals ch.Id
                             join dt in context.DepartureTimes
                             on v.VehicleDepartureTimeId equals dt.Id
                             join fc in context.Cities
                             on v.FromCityId equals fc.Id
                             join ds in context.Cities
                             on v.DestinationCityId equals ds.Id
                             select new VehiclesDetailsDto()
                             {
                                 Id = v.Id,
                                 ChauffeurId = ch.Id,
                                 ChauffeurFirstName = ch.FirstName,
                                 ChauffeurLastName = ch.LastName,
                                 FromCityId = fc.Id,
                                 FromCity = fc.CityName,
                                 DestinationCityId = ds.Id,
                                 DestinationCity = ds.CityName,
                                 VehicleDepartureTimeId = dt.Id,
                                 VehicleDepartureTime = dt.Time,
                                 VehiclePlateNumber = v.PlateNumber

                             };

                return result.ToList();
            }
        }
    }
}
