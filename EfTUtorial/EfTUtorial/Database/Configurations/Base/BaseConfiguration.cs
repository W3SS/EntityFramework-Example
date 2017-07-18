using System.Data.Entity.ModelConfiguration;
using EfTUtorial.Utils;

namespace EfTUtorial.Database.Configurations.Base
{
    public class BaseConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        protected BaseConfiguration()
        {
            HasKey(x => x.Id);
        }
    }
}
