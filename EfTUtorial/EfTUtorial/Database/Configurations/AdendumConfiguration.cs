using System.ComponentModel.DataAnnotations.Schema;
using EfTUtorial.Database.Configurations.Base;
using EfTUtorial.Database.Entities;

namespace EfTUtorial.Database.Configurations
{
    public class AdendumConfiguration : BaseConfiguration<Adendum>
    {
        private const string TableName = "Adendums";

        public AdendumConfiguration()
            : this("dbo")
        {

        }

        private AdendumConfiguration(string schema)
        {
            ToTable(TableName, schema);
            Property(x => x.AdendumContent)
                .HasColumnName("AdendumContent")
                .HasColumnType("nvarchar")
                .HasMaxLength(2000)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}