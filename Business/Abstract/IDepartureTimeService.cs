using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartureTimeService
    {
        IDataResult<List<DepartureTime>> GetAll();
        IDataResult<DepartureTime> GetById(int departureTimeId);
        IResult Add(DepartureTime departureTime);
        IResult Update(DepartureTime departureTime);
        IResult Delete(DepartureTime departureTime);
    }
}
