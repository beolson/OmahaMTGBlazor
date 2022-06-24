using OmahaMRG.Application.Entities;

namespace OmahaMRG.Application.Entities.Common
{
    public abstract class AuditableEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedByUserId { get; set; } = null!;
        public string UpdatedByUserId { get; set; } = null!;
        public OmahaMtgUser CreatedByUser { get; set; } = null!;
        public OmahaMtgUser UpdatedByUser { get; set; } = null!;
    }
}