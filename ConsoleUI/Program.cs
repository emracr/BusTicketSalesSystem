using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerService customerService = new CustomerManager(new EfCustomerDal());
            IChauffeurService chauffeurService = new ChauffeurManager(new EfChauffeurDal());
            ITicketService ticketService = new TicketManager(new EfTicketDal());
            IVehicleService vehicleService = new VehicleManager(new EfVehicleDal());

            //Customer customer1 = new Customer() {FirstName = "Deneme Adı Güncellendi", LastName = "Soyad", TC = "22222222222", Email = "deneme@gmail.com", Phone = "00000000000", GenderId = 1, DateOfBrith = new DateTime(2021 - 05 - 10), Password = "deneme" };
            //customerService.Add(customer1);

            //Chauffeur chauffeur1 = new Chauffeur() { FirstName = "Mehmet", LastName = "Bulut", Phone = "55236547895", GenderId = 1, DateOfBrith = new DateTime(1973 - 10 - 21) };
            //chauffeurService.Add(chauffeur1);

            //Ticket ticket1 = new Ticket() {CustomerId = 2, FromCityId = 47, DestinationCityId = 34, DepartureTimeId = 10, VehicleId = 1, DepartureDate = DateTime.Now, Seat = "8", Price = 150 };
            //ticketService.Add(ticket1);

            //Vehicle vehicle1 = new Vehicle() {ChauffeurId = 4, PlateNumber = "01 ADN 47" };
            //vehicleService.Add(vehicle1);

            //foreach (var vehicle in vehicleService.GetAll().Data)
            //{
            //    Console.WriteLine(vehicle.Id);
            //    Console.WriteLine(vehicle.ChauffeurId);
            //    Console.WriteLine(vehicle.PlateNumber);
            //    Console.WriteLine("-------------------------------------------");
            //}

            //foreach (var ticket in ticketService.GetAll().Data)
            //{
            //    Console.WriteLine(ticket.Id);
            //    Console.WriteLine(ticket.CustomerId);
            //    Console.WriteLine(ticket.DepartureDate.ToLongDateString());
            //    Console.WriteLine("-----------------------------------------");
            //}

            //foreach (var chauffeur in chauffeurService.GetAll().Data)
            //{
            //    Console.WriteLine(chauffeur.Id);
            //    Console.WriteLine(chauffeur.FirstName);
            //    Console.WriteLine(chauffeur.LastName);
            //    Console.WriteLine("-----------------------------------------");
            //}

            //foreach (var customer in customerService.GetAll().Data)
            //{
            //    Console.WriteLine(customer.Id);
            //    Console.WriteLine(customer.FirstName);
            //    Console.WriteLine(customer.LastName);
            //    Console.WriteLine(customer.TC);
            //    Console.WriteLine(customer.Email);
            //    Console.WriteLine(customer.Phone);
            //    Console.WriteLine(customer.GenderId);
            //    Console.WriteLine(customer.Password);
            //    Console.WriteLine("-----------------------------------------");
            //}

            Console.ReadLine();
        }
    }
}
