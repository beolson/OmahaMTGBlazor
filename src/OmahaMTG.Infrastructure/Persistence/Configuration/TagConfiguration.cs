using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmahaMRG.Application.Entities;

namespace OmahaMTG.Infrastructure.Persistence.Configuration
{
    internal class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder
                .HasOne(tag => tag.CreatedByUser)
                .WithMany(user => user.CreatedTags)
                .HasForeignKey(tag => tag.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(tag => tag.UpdatedByUser)
                .WithMany(user => user.UpdatedTags)
                .HasForeignKey(tag => tag.UpdatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}