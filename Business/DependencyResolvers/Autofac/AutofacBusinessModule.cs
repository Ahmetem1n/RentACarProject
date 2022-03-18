using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AdminManager>().As<IAdminService>();
            builder.RegisterType<EfAdminDal>().As<IAdminDal>();

            builder.RegisterType<BranchManager>().As<IBranchService>();
            builder.RegisterType<EfBranchDal>().As<IBranchDal>();

            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();

            builder.RegisterType<CarManager>().As<ICarService>();
            builder.RegisterType<EfCarDal>().As<ICarDal>();

            builder.RegisterType<CardManager>().As<ICardService>();
            builder.RegisterType<EfCardDal>().As<ICardDal>();

            builder.RegisterType<CarImageManager>().As<ICarImageService>();
            builder.RegisterType<EfCarImageDal>().As<ICarImageDal>();

            builder.RegisterType<CaseTypeManager>().As<ICaseTypeService>();
            builder.RegisterType<EfCaseTypeDal>().As<ICaseTypeDal>();

            builder.RegisterType<ClassManager>().As<IClassService>();
            builder.RegisterType<EfClassDal>().As<IClassDal>();

            builder.RegisterType<ColorManager>().As<IColorService>();
            builder.RegisterType<EfColorDal>().As<IColorDal>();

            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            builder.RegisterType<DrivingInformationManager>().As<IDrivingInformationService>();
            builder.RegisterType<EfDrivingInformationDal>().As<IDrivingInformationDal>();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>();

            builder.RegisterType<FuelManager>().As<IFuelService>();
            builder.RegisterType<EfFuelDal>().As<IFuelDal>();

            builder.RegisterType<GearManager>().As<IGearService>();
            builder.RegisterType<EfGearDal>().As<IGearDal>();

            builder.RegisterType<IdentityInformationManager>().As<IIdentityInformationService>();
            builder.RegisterType<EfIdentityInformationDal>().As<IIdentityInformationDal>();

            builder.RegisterType<ModelManager>().As<IModelService>();
            builder.RegisterType<EfModelDal>().As<IModelDal>();

            builder.RegisterType<PhoneNumberManager>().As<IPhoneNumberService>();
            builder.RegisterType<EfPhoneNumberDal>().As<IPhoneNumberDal>();

            builder.RegisterType<RentalDetailManager>().As<IRentalDetailService>();
            builder.RegisterType<EfRentalDetailDal>().As<IRentalDetailDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<UserRoleManager>().As<IUserRoleService>();
            builder.RegisterType<EfUserRoleDal>().As<IUserRoleDal>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
