////using Microsoft.EntityFrameworkCore;
////using Microsoft.EntityFrameworkCore.Metadata.Builders;
////using OmahaMTG.Domain.Entities;

////namespace OmahaMTG.Infrastructure.Persistence.Configuration
////{
////    internal class MeetingTagConfiguration : IEntityTypeConfiguration<MeetingTag>
////    {
////        public void Configure(EntityTypeBuilder<MeetingTag> builder)
////        {
////            builder.HasKey(er => new { er.MeetingId, er.TagId });

////            builder
////                .HasOne(meetingTag => meetingTag.CreatedByUser)
////                .WithMany(user => user.CreatedMeetingTags)
////                .HasForeignKey(meetingTag => meetingTag.CreatedByUserId)
////                .OnDelete(DeleteBehavior.Restrict);

////            builder
////                .HasOne(meetingTag => meetingTag.UpdatedByUser)
////                .WithMany(user => user.UpdatedMeetingTags)
////                .HasForeignKey(meetingTag => meetingTag.UpdatedByUserId)
////                .OnDelete(DeleteBehavior.Restrict);
////        }
////    }
////}

