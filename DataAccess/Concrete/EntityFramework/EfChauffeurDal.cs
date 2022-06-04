using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfChauffeurDal : EfEntityRepositoryBase<Chauffeur, BusTicketSalesContext>, IChauffeurDal
    {
        public List<ChauffeurDetailsDto> GetChauffeurDetails()
        {
            using (BusTicketSalesContext context = new BusTicketSalesContext())
            {
                var result = from ch in context.Chauffeurs
                             join g in context.Genders
                             on ch.GenderId equals g.Id
                             select new ChauffeurDetailsDto()
                             {
                                 Id = ch.Id,
                                 FirstName = ch.FirstName,
                                 LastName = ch.LastName,
                                 DateOfBrith = ch.DateOfBrith,
                                 Phone = ch.Phone,
                                 Gender = g.GenderName
                             };

                return result.ToList();
            }
        }
    }
}
