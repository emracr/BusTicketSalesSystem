using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();

            Bind<IChauffeurService>().To<ChauffeurManager>().InSingletonScope();
            Bind<IChauffeurDal>().To<EfChauffeurDal>().InSingletonScope();

            Bind<ITicketService>().To<TicketManager>().InSingletonScope();
            Bind<ITicketDal>().To<EfTicketDal>().InSingletonScope();

            Bind<IVehicleService>().To<VehicleManager>().InSingletonScope();
            Bind<IVehicleDal>().To<EfVehicleDal>().InSingletonScope();

            Bind<ICityService>().To<CityManager>().InSingletonScope();
            Bind<ICityDal>().To<EfCityDal>().InSingletonScope();

            Bind<IDepartureTimeService>().To<DepartureTimeManager>().InSingletonScope();
            Bind<IDepartureTimeDal>().To<EfDepartureTimeDal>().InSingletonScope();

            Bind<IAdminService>().To<AdminManager>().InSingletonScope();
            Bind<IAdminDal>().To<EfAdminDal>().InSingletonScope();

            Bind<ILoginLogService>().To<LoginLogManager>().InSingletonScope();
            Bind<ILoginLogDal>().To<EfLoginLogDal>().InSingletonScope();

            Bind<ITransactionLogService>().To<TransactionLogManager>().InSingletonScope();
            Bind<ITransactionLogDal>().To<EfTransactionLogDal>().InSingletonScope();

            Bind<IGenderService>().To<GenderManager>().InSingletonScope();
            Bind<IGenderDal>().To<EfGenderDal>().InSingletonScope();

            Bind<IDeletedCustomerService>().To<DeletedCustomerManager>().InSingletonScope();
            Bind<IDeletedCustomerDal>().To<EfDeletedCustomerDal>().InSingletonScope();

            Bind<IDeletedTicketService>().To<DeletedTicketManager>().InSingletonScope();
            Bind<IDeletedTicketDal>().To<EfDeletedTicketDal>().InSingletonScope();

            Bind<ISecurityQuestionService>().To<SecurityQuestionManager>().InSingletonScope();
            Bind<ISecurityQuestionDal>().To<EfSecurityQuestionDal>().InSingletonScope();
        }
    }
}
