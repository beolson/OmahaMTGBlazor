using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmahaMRG.Application.Entities;

namespace OmahaMTG.Infrastructure.Persistence.Configuration
{
    internal class PostTagConfiguration : IEntityTypeConfiguration<PostTag>
    {
        public void Configure(EntityTypeBuilder<PostTag> builder)
        {
            builder.HasKey(postTag => new { postTag.PostId, postTag.TagId });

            builder
                .HasOne(postTag => postTag.Post)
                .WithMany(post => post.PostTags)
                .HasForeignKey(postTag => postTag.PostId);

            builder
                .HasOne(postTag => postTag.Tag)
                .WithMany(tag => tag.PostTags)
                .HasForeignKey(postTag => postTag.TagId);

            builder
                .HasOne(postTag => postTag.CreatedByUser)
                .WithMany(user => user.CreatedPostTags)
                .HasForeignKey(post => post.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(postTag => postTag.UpdatedByUser)
                .WithMany(user => user.UpdatedPostTags)
                .HasForeignKey(postTag => postTag.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}