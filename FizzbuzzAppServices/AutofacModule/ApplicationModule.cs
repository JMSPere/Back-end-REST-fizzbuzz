﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzbuzzAppServices.AutofacModule
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<>().As<>().InstancePerDependency();

            base.Load(builder);
        }
    }
}
