//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OmahaMTG.Domain.Entities;

//namespace OmahaMTG.Infrastructure.Persistence.Configuration
//{
//    internal class PresentationPresenterConfiguration : IEntityTypeConfiguration<PresentationPresenter>
//    {
//        public void Configure(EntityTypeBuilder<PresentationPresenter> builder)
//        {
//            builder.HasKey(pp => new { pp.PresentationId, pp.PresenterId });

//            builder
//                .HasOne(presentationPresenter => presentationPresenter.CreatedByUser)
//                .WithMany(user => user.CreatedPresentationPresenters)
//                .HasForeignKey(presentationPresenter => presentationPresenter.CreatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            builder
//                .HasOne(presentationPresenter => presentationPresenter.UpdatedByUser)
//                .WithMany(user => user.UpdatedPresentationPresenters)
//                .HasForeignKey(presentationPresenter => presentationPresenter.UpdatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);
//        }
//    }
//}

