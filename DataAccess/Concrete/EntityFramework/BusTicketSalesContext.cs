using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class BusTicketSalesContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Chauffeur> Chauffeurs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<DepartureTime> DepartureTimes { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<LoginLog> LoginLogs { get; set; }
        public DbSet<TransactionLog> TransactionLogs { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<DeletedCustomer> DeletedCustomers { get; set; }
        public DbSet<DeletedTicket> DeletedTickets { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
    }
}
