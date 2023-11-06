using Autofac;
using Autofac.log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FizzbuzzAppServices;
using FizzbuzzAppServices.AutofacModule;

namespace Fizzbuzz.DistributedServices.Configuration
{
    public class AutofacConfiguration
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new ApplicationModule());
            builder.RegisterModule<Log4NetModule>();

            builder.RegisterType<Fizzbuzz>().As<IFizzbuzz>().InstancePerDependency();

            //builder.RegisterType<StudentAppService>().As<IStudentAppService>().InstancePerDependency();


            return builder.Build();
        }
    }
}