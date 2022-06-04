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
    public interface IChauffeurService
    {
        IDataResult<List<Chauffeur>> GetAll();
        IDataResult<List<ChauffeurDetailsDto>> GetChauffeurDetails();
        IDataResult<Chauffeur> GetById(int chauffeurId);
        IResult Add(Chauffeur chauffeur);
        IResult Update(Chauffeur chauffeur);
        IResult Delete(Chauffeur chauffeur);
    }
}
