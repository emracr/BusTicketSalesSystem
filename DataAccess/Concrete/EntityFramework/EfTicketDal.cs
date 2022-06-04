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
    public class EfTicketDal : EfEntityRepositoryBase<Ticket, BusTicketSalesContext>, ITicketDal
    {
        public List<TicketDetailsDto> GetTicketDetails()
        {
            using (BusTicketSalesContext context = new BusTicketSalesContext())
            {
                var result = from t in context.Tickets
                             join c in context.Customers
                             on t.CustomerId equals c.Id
                             join ct in context.Cities
                             on t.FromCityId equals ct.Id
                             join cts in context.Cities
                             on t.DestinationCityId equals cts.Id
                             join d in context.DepartureTimes
                             on t.DepartureTimeId equals d.Id
                             select new TicketDetailsDto()
                             {
                                 Id = t.Id,
                                 CustomerId = c.Id,
                                 TC = c.TC,
                                 FirstName = c.FirstName,
                                 LastName = c.LastName,
                                 Phone = c.Phone,
                                 VehicleId = t.VehicleId,
                                 FromCity = ct.CityName,
                                 DestinationCity = cts.CityName,
                                 DepartureTime = d.Time,
                                 DepartureDate = t.DepartureDate,
                                 Seat = t.Seat,
                                 Price = t.Price
                             };

                return result.ToList();
            }
        }

        public List<TicketExtendetDetailsDto> GetTicketExtendetDetails()
        {
            using (BusTicketSalesContext context = new BusTicketSalesContext())
            {
                var result = from t in context.Tickets
                             join c in context.Customers
                             on t.CustomerId equals c.Id
                             join ct in context.Cities
                             on t.FromCityId equals ct.Id
                             join cts in context.Cities
                             on t.DestinationCityId equals cts.Id
                             join vh in context.Vehicles
                             on t.VehicleId equals vh.Id
                             join dp in context.DepartureTimes
                             on t.DepartureTimeId equals dp.Id
                             join chf in context.Chauffeurs
                             on vh.ChauffeurId equals chf.Id
                             select new TicketExtendetDetailsDto()
                             {
                                 TicketId = t.Id,
                                 TC = c.TC,
                                 CustomerFisrtName = c.FirstName,
                                 CustomerLastName = c.LastName,
                                 CustomerPhone = c.Phone,
                                 From = ct.CityName,
                                 Destination = cts.CityName,
                                 Time = dp.Time,
                                 Date = t.DepartureDate,
                                 Seat = t.Seat,
                                 Price = t.Price,
                                 ChauffeurFisrtName = chf.FirstName,
                                 ChauffeurLastName = chf.LastName,
                                 ChauffeurPhone = chf.Phone,
                                 BusPlateNo = vh.PlateNumber
                             };

                return result.ToList();
            }
        }
        public List<TicketDetailsDto> GetTicketForTheMostLocationLastOneMonth()
        {
            using (BusTicketSalesContext context = new BusTicketSalesContext())
            {
                var result = from t in context.Tickets
                             group t by new
                             {
                                 t.FromCityId,
                                 t.DestinationCityId,
                                 t.DepartureDate.Month
                             }
                             into gcs
                             select new TicketDetailsDto()
                             {
                                 FromCityId = gcs.Key.FromCityId,
                                 DestinationCityId = gcs.Key.DestinationCityId,
                                 TicketCount = gcs.Count(),
                                 MonthNumber = gcs.Key.Month
                             };

                return result.ToList();
            }
        }

        public List<TicketDetailsDto> GetTicketForTheMostLocation()
        {
            using (BusTicketSalesContext context = new BusTicketSalesContext())
            {
                var result = from t in context.Tickets
                             group t by new
                             {
                                 t.FromCityId,
                                 t.DestinationCityId,
                             }
                             into gcs
                             select new TicketDetailsDto()
                             {
                                 FromCityId = gcs.Key.FromCityId,
                                 DestinationCityId = gcs.Key.DestinationCityId,
                                 TicketCount = gcs.Count(),
                             };

                return result.ToList();
            }
        }

        public List<TicketDetailsDto> GetTicketTopSellingMonth()
        {
            using (BusTicketSalesContext context = new BusTicketSalesContext())
            {
                var result = from t in context.Tickets
                             group t by new
                             {
                                 t.DepartureDate.Month
                             }
                             into gcs
                             select new TicketDetailsDto()
                             {
                                 MonthNumber = gcs.Key.Month,
                                 MonthCount = gcs.Count()
                             };

                return result.ToList();
            }
        }
    }
}
