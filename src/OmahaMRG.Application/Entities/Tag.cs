using OmahaMRG.Application.Entities.Common;


namespace OmahaMRG.Application.Entities
{
    public class Tag : AuditableEntity
    {
        public Tag()
        {

            PostTags = new List<PostTag>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable<PostTag> PostTags { get; set; }
    }
}
