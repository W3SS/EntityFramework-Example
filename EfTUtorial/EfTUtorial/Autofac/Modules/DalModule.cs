using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using EfTUtorial.Database;
using EfTUtorial.Database.Contracts;

namespace EfTUtorial.Autofac.Modules
{
    public class DalModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DatabaseContext>().As<IDatabaseContext>().InstancePerLifetimeScope();
        }
    }
}
