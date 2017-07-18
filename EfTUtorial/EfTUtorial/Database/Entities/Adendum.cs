using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfTUtorial.Utils;

namespace EfTUtorial.Database.Entities
{
    public class Adendum : BaseEntity
    {
        public string AdendumContent { get; set; }
        public virtual Note Note { get; set; }
        public Guid NoteId { get; set; }
    }
}
