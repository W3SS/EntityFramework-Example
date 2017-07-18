using System.Data.Entity;
using EfTUtorial.Database.Configurations;
using EfTUtorial.Utils.Contracts;

namespace EfTUtorial.Database
{
    public class ContextConfigurationModule : IConfigurationModule
    {
        public void Register(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new NoteConfiguration());
            modelBuilder.Configurations.Add(new AdendumConfiguration());
        }
    }
}