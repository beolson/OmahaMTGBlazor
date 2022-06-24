//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OmahaMTG.Domain.Entities;

//namespace OmahaMTG.Infrastructure.Persistence.Configuration
//{
//    internal class PresentationConfiguration : IEntityTypeConfiguration<Presentation>
//    {
//        public void Configure(EntityTypeBuilder<Presentation> builder)
//        {
//            //throw new System.NotImplementedException();

//            builder
//                .HasOne(presentation => presentation.CreatedByUser)
//                .WithMany(user => user.CreatedPresentations)
//                .HasForeignKey(post => post.CreatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            builder
//                .HasOne(presentation => presentation.UpdatedByUser)
//                .WithMany(user => user.UpdatedPresentations)
//                .HasForeignKey(post => post.UpdatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);
//        }
//    }
//}

