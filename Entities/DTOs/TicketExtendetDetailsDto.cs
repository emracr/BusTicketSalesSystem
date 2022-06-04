using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class TicketExtendetDetailsDto
    {
        public int TicketId { get; set; }
        public string TC { get; set; }
        public string CustomerFisrtName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhone { get; set; }

        public string From { get; set; }
        public string Destination { get; set; }
        public string Time { get; set; }
        public DateTime Date { get; set; }
        public string Seat { get; set; }
        public decimal Price { get; set; }

        public string ChauffeurFisrtName { get; set; }
        public string ChauffeurLastName { get; set; }
        public string ChauffeurPhone { get; set; }
        public string BusPlateNo { get; set; }
    }
}
