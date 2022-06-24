//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OmahaMTG.Domain.Entities;


//namespace OmahaMTG.Infrastructure.Persistence.Configuration
//{
//    internal class PresenterConfiguration : IEntityTypeConfiguration<Presenter>
//    {
//        public void Configure(EntityTypeBuilder<Presenter> builder)
//        {
//            builder
//                .HasOne(post => post.CreatedByUser)
//                .WithMany(user => user.CreatedPresenters)
//                .HasForeignKey(post => post.CreatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            builder
//                .HasOne(post => post.UpdatedByUser)
//                .WithMany(user => user.UpdatedPresenters)
//                .HasForeignKey(post => post.UpdatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            builder
//                .HasOne(presenter => presenter.User)
//                .WithOne(user => user.Presenter)
//                .HasForeignKey<Presenter>(presenter => presenter.OmahaMtgUserId)
//                .OnDelete(DeleteBehavior.Restrict);
//        }
//    }
//}

