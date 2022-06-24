using Microsoft.EntityFrameworkCore;
using OmahaMRG.Application.Entities;

namespace OmahaMRG.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Post> Posts { get; }
        DbSet<PostTag> PostTags { get; }
        DbSet<Tag> Tags { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
