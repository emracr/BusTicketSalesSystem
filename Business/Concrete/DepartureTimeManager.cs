using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DepartureTimeManager : IDepartureTimeService
    {
        IDepartureTimeDal _departureTimeDal;
        public DepartureTimeManager(IDepartureTimeDal departureTimeDal)
        {
            _departureTimeDal = departureTimeDal;
        }

        public IResult Add(DepartureTime departureTime)
        {
            _departureTimeDal.Add(departureTime);
            return new SuccessResult();
        }

        public IResult Delete(DepartureTime departureTime)
        {
            _departureTimeDal.Delete(departureTime);
            return new SuccessResult();
        }

        public IDataResult<List<DepartureTime>> GetAll()
        {
            return new SuccessDataResult<List<DepartureTime>>(_departureTimeDal.GetAll());
        }

        public IDataResult<DepartureTime> GetById(int departureTimeId)
        {
            return new SuccessDataResult<DepartureTime>(_departureTimeDal.Get(d => d.Id == departureTimeId));
        }

        public IResult Update(DepartureTime departureTime)
        {
            _departureTimeDal.Update(departureTime);
            return new SuccessResult();
        }
    }
}
