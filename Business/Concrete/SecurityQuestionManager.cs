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
    public class SecurityQuestionManager : ISecurityQuestionService
    {
        ISecurityQuestionDal _securityQuestionDal;
        public SecurityQuestionManager(ISecurityQuestionDal securityQuestionDal)
        {
            _securityQuestionDal = securityQuestionDal;
        }

        public IResult Add(SecurityQuestion securityQuestion)
        {
            _securityQuestionDal.Add(securityQuestion);
            return new SuccessResult();
        }

        public IResult Delete(SecurityQuestion securityQuestion)
        {
            _securityQuestionDal.Delete(securityQuestion);
            return new SuccessResult();
        }

        public IDataResult<List<SecurityQuestion>> GetAll()
        {
            return new SuccessDataResult<List<SecurityQuestion>>(_securityQuestionDal.GetAll());
        }

        public IDataResult<SecurityQuestion> GetById(int securityQuestionId)
        {
            return new SuccessDataResult<SecurityQuestion>(_securityQuestionDal.Get(s => s.Id == securityQuestionId));
        }

        public IResult Update(SecurityQuestion securityQuestion)
        {
            _securityQuestionDal.Update(securityQuestion);
            return new SuccessResult();
        }
    }
}
