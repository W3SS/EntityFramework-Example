using System.Data.Entity.Infrastructure;

namespace EfTUtorial.Database
{
    public class ContextFactory : IDbContextFactory<DatabaseContext>
    {
#if DEBUG

        private const string DbConnection = "Data Source=.;Initial Catalog=EfTutorial;Integrated Security=True;";
        public DatabaseContext Create()
        {
            return new DatabaseContext(DbConnection);
        }

#endif

    }
}