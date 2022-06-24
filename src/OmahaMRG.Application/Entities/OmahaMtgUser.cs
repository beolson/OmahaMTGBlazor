using Microsoft.AspNetCore.Identity;

namespace OmahaMRG.Application.Entities
{
    public class OmahaMtgUser : IdentityUser
    {

        public DateTime? LastLoginDate { get; set; }
        public DateTime CreateDate { get; set; }


        public IEnumerable<Post> CreatedPosts { get; set; } = new List<Post>();

        public IEnumerable<Post> UpdatedPosts { get; set; } = new List<Post>();


        public IEnumerable<Tag> CreatedTags { get; set; } = new List<Tag>();

        public IEnumerable<Tag> UpdatedTags { get; set; } = new List<Tag>();



        public IEnumerable<PostTag> CreatedPostTags { get; set; } = new List<PostTag>();

        public IEnumerable<PostTag> UpdatedPostTags { get; set; } = new List<PostTag>();



        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int EmailFailures { get; set; }
        public bool IsUnsubscribed { get; set; }
    }
}