using System.Data.Entity;
using EfTUtorial.Database.Contracts;
using EfTUtorial.Database.Entities;
using EfTUtorial.Extensions;
using EfTUtorial.Utils;
using EfTUtorial.Utils.Contracts;

namespace EfTUtorial.Database
{
    public class DatabaseContext : DbContextBase, IDatabaseContext
    {
        public DatabaseContext(IConfiguration configuration)
            : base(configuration, new ContextConfigurationModule())
        {
            this.DisableDatabaseInitialization();
        }

        // only used in development
        internal DatabaseContext(string connectionString)
            : base(connectionString, new ContextConfigurationModule())
        {
            this.DisableDatabaseInitialization();
        }

        public IDbSet<Note> Notes { get; set; }
    }
}
