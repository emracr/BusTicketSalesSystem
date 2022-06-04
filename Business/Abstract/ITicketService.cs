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
    public interface ITicketService
    {
        IDataResult<List<Ticket>> GetAll();
        IDataResult<List<TicketDetailsDto>> GetTicketDetails();
        IDataResult<List<TicketExtendetDetailsDto>> GetTicketExtendetDetails();
        IDataResult<List<TicketDetailsDto>> GetTicketForTheMostLocation();
        IDataResult<List<TicketDetailsDto>> GetTicketForTheMostLocationLastOneMonth();
        IDataResult<List<TicketDetailsDto>> GetTicketTopSellingMonth();
        IDataResult<Ticket> GetById(int ticketId);
        IResult Add(Ticket ticket);
        IResult Update(Ticket ticket);
        IResult Delete(Ticket ticket);
    }
}
