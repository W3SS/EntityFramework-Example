using System.ComponentModel.DataAnnotations.Schema;
using EfTUtorial.Database.Configurations.Base;
using EfTUtorial.Database.Entities;

namespace EfTUtorial.Database.Configurations
{
    public class NoteConfiguration : BaseConfiguration<Note>
    {
        private const string TableName = "Notes";

        public NoteConfiguration() : this("dbo")
        {

        }

        private NoteConfiguration(string schema)
        {
            ToTable(TableName, schema);

            Property(x => x.Timestamp)
                .HasColumnName("Timestamp")
                .HasColumnType("datetime")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Message)
                .HasColumnName("Message")
                .HasColumnType("nvarchar")
                .HasMaxLength(2000)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Author)
                .HasColumnName("Author")
                .HasColumnType("nvarchar")
                .HasMaxLength(2000)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            HasMany(x => x.Adendums).WithRequired(x => x.Note).HasForeignKey(x => x.NoteId);
        }
    }

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
