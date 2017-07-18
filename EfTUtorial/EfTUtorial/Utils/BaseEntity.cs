using System;
using EfTUtorial.Utils.Contracts;

namespace EfTUtorial.Utils
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
    }
}