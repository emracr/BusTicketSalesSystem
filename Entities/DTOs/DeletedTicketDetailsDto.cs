using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class DeletedTicketDetailsDto : IDto
    {
        public int Id { get; set; }
        public string TC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FromCity { get; set; }
        public string DestinationCity { get; set; }
        public string DepartureTime { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Seat { get; set; }
        public decimal Price { get; set; }
    }
}
