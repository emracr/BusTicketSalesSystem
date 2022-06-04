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
    public class EfTransactionLogDal : EfEntityRepositoryBase<TransactionLog, BusTicketSalesContext>, ITransactionLogDal
    {
        public List<TransactionLogDetailsDto> GetTransactionLogDetails()
        {
            using (BusTicketSalesContext context = new BusTicketSalesContext())
            {
                var result = from tl in context.TransactionLogs
                             join tt in context.TransactionTypes
                             on tl.TransactionNameId equals tt.Id
                             join c in context.Customers
                             on tl.CustomerId equals c.Id
                             select new TransactionLogDetailsDto()
                             {
                                 Id = tl.Id,
                                 DateOfTransaction = tl.DateOfTransaction,
                                 TransactionTypeName = tt.TransactionName,
                                 FirstName = c.FirstName,
                                 LastName = c.LastName,
                                 TC = c.TC
                             };

                return result.ToList();
            }
        }
    }
}
