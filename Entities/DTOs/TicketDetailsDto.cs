using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class TicketDetailsDto : IDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string TC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int VehicleId { get; set; }
        public string FromCity { get; set; }
        public int FromCityId { get; set; }
        public string DestinationCity { get; set; }
        public int DestinationCityId { get; set; }
        public string DepartureTime { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Seat { get; set; }
        public decimal Price { get; set; }
        public int TicketCount { get; set; }
        public int MonthNumber { get; set; }
        public int MonthCount { get; set; }
    }
}
