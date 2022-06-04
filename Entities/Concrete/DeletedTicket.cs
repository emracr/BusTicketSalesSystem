﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DeletedTicket : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int FromCityId { get; set; }
        public int DestinationCityId { get; set; }
        public int VehicleId { get; set; }
        public int DepartureTimeId { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Seat { get; set; }
        public decimal Price { get; set; }
    }
}
