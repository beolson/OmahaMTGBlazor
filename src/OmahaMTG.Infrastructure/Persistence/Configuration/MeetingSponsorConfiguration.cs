//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OmahaMTG.Domain.Entities;

//namespace OmahaMTG.Infrastructure.Persistence.Configuration
//{
//    internal class MeetingSponsorConfiguration : IEntityTypeConfiguration<MeetingSponsor>
//    {
//        public void Configure(EntityTypeBuilder<MeetingSponsor> builder)
//        {
//            builder.HasKey(es => new { es.MeetingId, es.SupporterId });

//            builder
//                .HasOne(sponsor => sponsor.CreatedByUser)
//                .WithMany(user => user.CreatedMeetingSupporters)
//                .HasForeignKey(sponsor => sponsor.CreatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            builder
//                .HasOne(sponsor => sponsor.UpdatedByUser)
//                .WithMany(user => user.UpdatedMeetingSupporters)
//                .HasForeignKey(sponsor => sponsor.UpdatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            //builder.Property(ms => ms.Meeting);
//        }
//    }
//}

