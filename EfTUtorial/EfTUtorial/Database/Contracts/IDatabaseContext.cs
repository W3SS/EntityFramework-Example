using System.Data.Entity;
using EfTUtorial.Database.Entities;
using EfTUtorial.Utils.Contracts;

namespace EfTUtorial.Database.Contracts
{
    public interface IDatabaseContext : IDbContext
    {
        IDbSet<Note> Notes { get; }
    }
}