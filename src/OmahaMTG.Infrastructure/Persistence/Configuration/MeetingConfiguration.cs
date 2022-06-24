//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OmahaMTG.Domain.Entities;

//namespace OmahaMTG.Infrastructure.Persistence.Configuration
//{
//    internal class MeetingConfiguration : IEntityTypeConfiguration<Meeting>
//    {
//        public void Configure(EntityTypeBuilder<Meeting> builder)
//        {
//            builder
//                .HasMany(m => m.MeetingTags).WithOne(mt => mt.Meeting).OnDelete(DeleteBehavior.NoAction);

//            builder
//                .HasMany(m => m.MeetingSponsors).WithOne(mt => mt.Meeting).OnDelete(DeleteBehavior.NoAction);

//            builder
//                .HasMany(m => m.Presentations).WithOne(mt => mt.Meeting).OnDelete(DeleteBehavior.NoAction);

//            builder
//                .HasOne(meeting => meeting.CreatedByUser)
//                .WithMany(user => user.CreatedMeetings)
//                .HasForeignKey(post => post.CreatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            builder
//                .HasOne(meeting => meeting.UpdatedByUser)
//                .WithMany(user => user.UpdatedMeetings)
//                .HasForeignKey(post => post.UpdatedByUserId)
//                .OnDelete(DeleteBehavior.Restrict);
//        }
//    }
//}

