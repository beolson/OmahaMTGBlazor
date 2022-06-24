using OmahaMRG.Application.Entities.Common;


namespace OmahaMRG.Application.Entities
{
    public class Post : AuditableEntity
    {
        public Post()
        {

            PostTags = new List<PostTag>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public DateTime? PublishStartTime { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDraft { get; set; }
        public IEnumerable<PostTag> PostTags { get; set; }
    }
}
