using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using CrossCutting.Logging;
using Fizzbuzz.DistributedServices;
using FizzbuzzAppServices.Integration.Tests.AutofacModule;
using log4net;

namespace Fizzbuzz.DistributedServices.Integration.Tests.AutofacModule
{
    public class WCFServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new FizzbuzzAppServicesModule());

            builder.RegisterInstance(LogManager.GetLogger("AppLogger")).As<ILog>();
            builder.RegisterType<LogWrapper>().As<ILogWrapper>().InstancePerDependency();

            builder.RegisterType<Fizzbuzz>().As<IFizzbuzz>();
        }
    }
}
