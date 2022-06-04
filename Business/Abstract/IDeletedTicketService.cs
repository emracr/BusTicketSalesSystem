using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDeletedTicketService
    {
        IDataResult<List<DeletedTicket>> GetAll();
        IDataResult<List<DeletedTicketDetailsDto>> GetDeletedTicketDetails();
        IResult Add(DeletedTicket deletedTicket);
    }
}
