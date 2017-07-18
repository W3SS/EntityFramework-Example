using Autofac;
using EfTUtorial.Autofac.Modules;
using EfTUtorial.Utils;
using EfTUtorial.Utils.Contracts;

namespace EfTUtorial.Autofac
{
    public static class AutofacConfiguration
    {
        public static IContainer Container { get; private set; }
        public static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.Register<IConfiguration>(c => new Configuration()).SingleInstance();

            // register our database module

            builder.RegisterModule(new DalModule());    
            // register resolver
            Container = builder.Build();
        }
    }
}
