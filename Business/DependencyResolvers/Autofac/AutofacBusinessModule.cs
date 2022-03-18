using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<ProductManager>().As<IProductService>();
            //builder.RegisterType<EfProductDal>().As<IProductDal>();

            //builder.RegisterType<CategoryManager>().As<ICategoryService>();
            //builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            //builder.RegisterType<CustomerManager>().As<ICustomerService>();
            //builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            //builder.RegisterType<OrderManager>().As<IOrderService>();
            //builder.RegisterType<EfOrderDal>().As<IOrderDal>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
