using System.Data.Entity.Migrations;

namespace EfTUtorial.Database
{
    public class ContextConfiguration : DbMigrationsConfiguration<DatabaseContext>
    {
        /// <summary>
        /// this basically tells no to entity framework running migrations automatically by itself
        /// </summary>
        public ContextConfiguration()
        {
            // disable automatic migrations
            AutomaticMigrationsEnabled = false;
        }
    }
}