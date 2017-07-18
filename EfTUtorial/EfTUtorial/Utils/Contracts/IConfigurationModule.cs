using System.Data.Entity;

namespace EfTUtorial.Utils.Contracts
{
    public interface IConfigurationModule
    {
        void Register(DbModelBuilder modelBuilder);
    }
}