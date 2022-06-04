using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Vehicle : IEntity
    {
        public int Id { get; set; }
        public int ChauffeurId { get; set; }
        public int VehicleDepartureTimeId { get; set; }
        public int FromCityId { get; set; }
        public int DestinationCityId { get; set; }
        public string PlateNumber { get; set; }
    }
}
