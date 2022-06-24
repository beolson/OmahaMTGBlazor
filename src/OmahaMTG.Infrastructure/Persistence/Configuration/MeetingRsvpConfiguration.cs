//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OmahaMTG.Domain.Entities;

//namespace OmahaMTG.Infrastructure.Persistence.Configuration
//{
//    internal class MeetingRsvpConfiguration : IEntityTypeConfiguration<MeetingRsvp>
//    {
//        public void Configure(EntityTypeBuilder<MeetingRsvp> builder)
//        {
//            builder.HasKey(_ => new { _.MeetingId, _.UserId });

//            builder
//                .HasOne(rsvp => rsvp.CreatedByUser)
//                .WithMany(user => user.CreatedMeetingRsvps)
//                .HasForeignKey(rsvp => rsvp.CreatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            builder
//                .HasOne(rsvp => rsvp.UpdatedByUser)
//                .WithMany(user => user.UpdatedMeetingRsvps)
//                .HasForeignKey(rsvp => rsvp.UpdatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);
//            //builder.Property(mr => mr.User);
//            //builder.Property(mr => mr.Meeting);
//        }
//    }
//}

