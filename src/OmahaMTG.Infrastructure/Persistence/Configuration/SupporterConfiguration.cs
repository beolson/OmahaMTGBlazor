//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OmahaMTG.Domain.Entities;


//namespace OmahaMTG.Infrastructure.Persistence.Configuration
//{
//    internal class SupporterConfiguration : IEntityTypeConfiguration<Supporter>
//    {
//        public void Configure(EntityTypeBuilder<Supporter> builder)
//        {
//            builder
//                .HasOne(post => post.CreatedByUser)
//                .WithMany(user => user.CreatedSupporters)
//                .HasForeignKey(post => post.CreatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            builder
//                .HasOne(post => post.UpdatedByUser)
//                .WithMany(user => user.UpdatedSupporters)
//                .HasForeignKey(post => post.UpdatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);
//        }
//    }
//}

