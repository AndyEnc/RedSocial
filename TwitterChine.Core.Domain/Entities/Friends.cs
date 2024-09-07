using TwitterChine.Core.Domain.Common;

namespace TwitterChine.Core.Domain.Entities
{
    public class Friends : AuditableBaseEntity
    {
        public string IdFriend { get; set; } = null!;
        public string UserName {  get; set; } = null!;
        public string IdUser { get; set; } = null!;
    }
}
