using Autofac;
using FizzbuzzAppServices.Contracts;
using Infrastructure.FizzbuzzRepository.Integration.Tests.AutofacModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzbuzzAppServices.Integration.Tests.AutofacModule
{
    public class FizzbuzzAppServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new InfrastructureModule());

            builder.RegisterType<FizzbuzzAppServices.Implementations.FizzbuzzAppServices>().As<IFizzbuzzAppServices>();
        }
    }
}
