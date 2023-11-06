using Autofac;
using CrossCutting.Configuration;
using Infrastructure.FizzbuzzRepository.Contracts;
using Infrastructure.FizzbuzzRepository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Abstractions;

namespace FizzbuzzAppServices.AutofacModule
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FizzbuzzRepository>().As<IFizzbuzzRepository>().InstancePerDependency();
            builder.RegisterType<CreateConfigManager>().As<IConfiguration>().InstancePerDependency();
            builder.RegisterType<FileManager>().As<IFileManager>().InstancePerDependency();
            builder.RegisterType<FileSystem>().As<IFileSystem>().InstancePerDependency();

            base.Load(builder);
        }
    }
}
