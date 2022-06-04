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
    public class EfDeletedTicketDal : EfEntityRepositoryBase<DeletedTicket, BusTicketSalesContext>, IDeletedTicketDal
    {
        public List<DeletedTicketDetailsDto> GetDeletedTicketDetails()
        {
            using (BusTicketSalesContext context = new BusTicketSalesContext())
            {
                var result = ((from t in context.DeletedTickets
                               join c in context.Customers
                               on t.CustomerId equals c.Id
                               join ct in context.Cities
                               on t.FromCityId equals ct.Id
                               join cts in context.Cities
                               on t.DestinationCityId equals cts.Id
                               join d in context.DepartureTimes
                               on t.DepartureTimeId equals d.Id
                               select new DeletedTicketDetailsDto()
                               {
                                   Id = t.Id,
                                   TC = c.TC,
                                   FirstName = c.FirstName,
                                   LastName = c.LastName,
                                   FromCity = ct.CityName,
                                   DestinationCity = cts.CityName,
                                   DepartureTime = d.Time,
                                   DepartureDate = t.DepartureDate,
                                   Seat = t.Seat,
                                   Price = t.Price
                               })
                             .Union(
                    from t in context.DeletedTickets
                    join c in context.DeletedCustomers
                    on t.CustomerId equals c.Id
                    join ct in context.Cities
                    on t.FromCityId equals ct.Id
                    join cts in context.Cities
                    on t.DestinationCityId equals cts.Id
                    join d in context.DepartureTimes
                    on t.DepartureTimeId equals d.Id
                    select new DeletedTicketDetailsDto()
                    {
                        Id = t.Id,
                        TC = c.TC,
                        FirstName = c.FirstName,
                        LastName = c.LastName,
                        FromCity = ct.CityName,
                        DestinationCity = cts.CityName,
                        DepartureTime = d.Time,
                        DepartureDate = t.DepartureDate,
                        Seat = t.Seat,
                        Price = t.Price
                    }));

                return result.ToList();
            }
        }
    }
}
