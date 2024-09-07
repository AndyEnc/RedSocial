using TwitterChine.Core.Domain.Common;
using TwitterChine.Core.Domain.Entities;

namespace TwitterChine.Core.Domain.Entities
{
    public class Posts: AuditableBaseEntity
    {
        public string Image { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime DateOfCreated { get; set; }
        //Navegation Properties
        public string IdUser { get; set; } = null!;
        public ICollection<Comments> Comments { get; set; }

    }
}
