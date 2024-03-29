﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDeletedCustomerService
    {
        IDataResult<List<DeletedCustomer>> GetAll();
        IDataResult<List<DeletedCustomerDetailsDto>> GetDeletedCustomerDetails();
        IResult Add(DeletedCustomer deletedCustomer);
    }
}
