using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class VehiclesDetailsDto : IDto
    {
        public int Id { get; set; }
        public int ChauffeurId { get; set; }
        public string ChauffeurFirstName { get; set; }
        public string ChauffeurLastName { get; set; }
        public int VehicleDepartureTimeId { get; set; }
        public string VehicleDepartureTime { get; set; }
        public string VehiclePlateNumber { get; set; }
        public int FromCityId { get; set; }
        public string FromCity { get; set; }
        public int DestinationCityId { get; set; }
        public string DestinationCity { get; set; }
    }
}
