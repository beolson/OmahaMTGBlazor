using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmahaMRG.Application.Entities;

namespace OmahaMTG.Infrastructure.Persistence.Configuration
{
    internal class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder
                .HasOne(post => post.CreatedByUser)
                .WithMany(user => user.CreatedPosts)
                .HasForeignKey(post => post.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(post => post.UpdatedByUser)
                .WithMany(user => user.UpdatedPosts)
                .HasForeignKey(post => post.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}