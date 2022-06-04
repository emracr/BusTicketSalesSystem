using Business.Abstract;
using Business.Constants;
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
    public class DeletedTicketManager : IDeletedTicketService
    {
        IDeletedTicketDal _deletedTicketDal;
        public DeletedTicketManager(IDeletedTicketDal deletedTicketDal)
        {
            _deletedTicketDal = deletedTicketDal;
        }

        public IResult Add(DeletedTicket deletedTicket)
        {
            _deletedTicketDal.Add(deletedTicket);
            return new SuccessResult();
        }

        public IDataResult<List<DeletedTicket>> GetAll()
        {
            return new SuccessDataResult<List<DeletedTicket>>(_deletedTicketDal.GetAll());
        }

        public IDataResult<List<DeletedTicketDetailsDto>> GetDeletedTicketDetails()
        {
            return new SuccessDataResult<List<DeletedTicketDetailsDto>>(_deletedTicketDal.GetDeletedTicketDetails());
        }
    }
}
