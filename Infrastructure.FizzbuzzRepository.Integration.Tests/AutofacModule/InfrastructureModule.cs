using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Infrastructure.FizzbuzzRepository.Integration.Tests.AutofacModule
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FizzbuzzRepository.FizzbuzzRepository>().As<Infrastructure.FizzbuzzRepository.Contracts.IFizzbuzzRepository>();
            builder.RegisterType<FizzbuzzRepository.FileManager>().As<Infrastructure.FizzbuzzRepository.Contracts.IFileManager>();
        }
    }
}
