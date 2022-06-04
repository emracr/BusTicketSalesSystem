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
    public class ChauffeurManager : IChauffeurService
    {
        IChauffeurDal _chauffeurDal;
        public ChauffeurManager(IChauffeurDal chauffeurDal)
        {
            _chauffeurDal = chauffeurDal;
        }

        public IResult Add(Chauffeur chauffeur)
        {
            _chauffeurDal.Add(chauffeur);
            return new SuccessResult();
        }

        public IResult Delete(Chauffeur chauffeur)
        {
            _chauffeurDal.Delete(chauffeur);
            return new SuccessResult();
        }

        public IDataResult<List<Chauffeur>> GetAll()
        {
            return new SuccessDataResult<List<Chauffeur>>(_chauffeurDal.GetAll());
        }

        public IDataResult<Chauffeur> GetById(int chauffeurId)
        {
            return new SuccessDataResult<Chauffeur>(_chauffeurDal.Get(c => c.Id == chauffeurId));
        }

        public IDataResult<List<ChauffeurDetailsDto>> GetChauffeurDetails()
        {
            return new SuccessDataResult<List<ChauffeurDetailsDto>>(_chauffeurDal.GetChauffeurDetails());
        }

        public IResult Update(Chauffeur chauffeur)
        {
            _chauffeurDal.Update(chauffeur);
            return new SuccessResult();
        }
    }
}
