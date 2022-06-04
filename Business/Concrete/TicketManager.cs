using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TicketManager : ITicketService
    {
        ITicketDal _ticketDal;
        public TicketManager(ITicketDal ticketDal)
        {
            _ticketDal = ticketDal;
        }

        public IResult Add(Ticket ticket)
        {
            _ticketDal.Add(ticket);
            return new SuccessResult();
        }

        public IResult Delete(Ticket ticket)
        {
            _ticketDal.Delete(ticket);
            return new SuccessResult();
        }

        public IDataResult<List<Ticket>> GetAll()
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetAll());
        }

        public IDataResult<Ticket> GetById(int ticketId)
        {
            return new SuccessDataResult<Ticket>(_ticketDal.Get(t => t.Id == ticketId));
        }

        public IDataResult<List<TicketDetailsDto>> GetTicketDetails()
        {
            return new SuccessDataResult<List<TicketDetailsDto>>(_ticketDal.GetTicketDetails());
        }

        public IDataResult<List<TicketExtendetDetailsDto>> GetTicketExtendetDetails()
        {
            return new SuccessDataResult<List<TicketExtendetDetailsDto>>(_ticketDal.GetTicketExtendetDetails());
        }

        public IDataResult<List<TicketDetailsDto>> GetTicketForTheMostLocation()
        {
            return new SuccessDataResult<List<TicketDetailsDto>>(_ticketDal.GetTicketForTheMostLocation());
        }

        public IDataResult<List<TicketDetailsDto>> GetTicketForTheMostLocationLastOneMonth()
        {
            return new SuccessDataResult<List<TicketDetailsDto>>(_ticketDal.GetTicketForTheMostLocationLastOneMonth());
        }

        public IDataResult<List<TicketDetailsDto>> GetTicketTopSellingMonth()
        {
            return new SuccessDataResult<List<TicketDetailsDto>>(_ticketDal.GetTicketTopSellingMonth());
        }

        public IResult Update(Ticket ticket)
        {
            _ticketDal.Update(ticket);
            return new SuccessResult();
        }
    }
}
