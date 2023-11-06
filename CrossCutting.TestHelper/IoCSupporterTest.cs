using Autofac;
using Autofac.Core;

namespace CrossCutting.TestHelper
{
    public class IoCSupporterTest
    {
        private readonly IContainer container;

        public IoCSupporterTest()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new IModule());

            container = builder.Build();
        }

        protected TEntity Resolve<TEntity>()
        {
            return container.Resolve<TEntity>();
        }

        protected void ShutdownIoC()
        {
            container.Dispose();
        }
    }
}
