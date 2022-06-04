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
    public class EfDeletedCustomerDal : EfEntityRepositoryBase<DeletedCustomer, BusTicketSalesContext>, IDeletedCustomerDal
    {
        public List<DeletedCustomerDetailsDto> GetDeletedCustomerDetails()
        {
            using (BusTicketSalesContext context = new BusTicketSalesContext())
            {
                var result = from dc in context.DeletedCustomers
                             join g in context.Genders
                             on dc.GenderId equals g.Id
                             select new DeletedCustomerDetailsDto()
                             {
                                 Id = dc.Id,
                                 TC = dc.TC,
                                 FirstName = dc.FirstName,
                                 LastName = dc.LastName,
                                 Email = dc.Email,
                                 Phone = dc.Phone,
                                 DateOfBirth = dc.DateOfBirth,
                                 Gender = g.GenderName
                             };

                return result.ToList();
            }
        }
    }
}
