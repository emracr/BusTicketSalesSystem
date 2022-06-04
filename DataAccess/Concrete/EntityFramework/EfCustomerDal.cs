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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, BusTicketSalesContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (BusTicketSalesContext context = new BusTicketSalesContext())
            {
                var result = from c in context.Customers
                             join g in context.Genders
                             on c.GenderId equals g.Id
                             select new CustomerDetailDto()
                             {
                                 Id = c.Id,
                                 FirstName = c.FirstName,
                                 LastName = c.LastName,
                                 TC = c.TC,
                                 Email = c.Email,
                                 DateOfBrith = c.DateOfBrith,
                                 Phone = c.Phone,
                                 Gender = g.GenderName
                             };

                return result.ToList();
            }
        }
    }
}
