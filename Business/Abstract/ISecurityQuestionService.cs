using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISecurityQuestionService
    {
        IDataResult<List<SecurityQuestion>> GetAll();
        IDataResult<SecurityQuestion> GetById(int securityQuestionId);
        IResult Add(SecurityQuestion securityQuestion);
        IResult Update(SecurityQuestion securityQuestion);
        IResult Delete(SecurityQuestion securityQuestion);
    }
}
