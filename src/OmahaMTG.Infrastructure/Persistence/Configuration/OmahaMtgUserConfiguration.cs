﻿//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using OmahaMTG.Domain.Entities;

//namespace OmahaMTG.Infrastructure.Persistence.Configuration
//{
//    internal class OmahaMtgUserConfiguration : IEntityTypeConfiguration<OmahaMtgUser>
//    {
//        public void Configure(EntityTypeBuilder<OmahaMtgUser> builder)
//        {

//            //builder
//            //    .HasMany(m => m.CreatedPresenters).WithOne(mt => mt.CreatedByUser);
//            //builder
//            //    .HasMany(m => m.UpdatedPresenters).WithOne(mt => mt.UpdatedByUser);

//            //builder
//            //    .HasOne(m => m.Presenter)
//            //    .WithOne(mt => mt.User)
//            //    //   .HasForeignKey<OmahaMtgUser>(_ => _.Id)
//            //    .HasForeignKey<Presenter>(_ => _.OmahaMtgUserId);


//            //builder
//            //    .HasMany(m => m.CreatedHosts).WithOne(mt => mt.CreatedByUser);
//            //builder
//            //    .HasMany(m => m.UpdatedHosts).WithOne(mt => mt.UpdatedByUser);

//            //builder
//            //    .HasMany(m => m.CreatedMeetings).WithOne(mt => mt.CreatedByUser);
//            //builder
//            //    .HasMany(m => m.UpdatedMeetings).WithOne(mt => mt.UpdatedByUser);

//            //builder
//            //    .HasMany(m => m.CreatedPosts).WithOne(mt => mt.CreatedByUser);
//            //builder
//            //    .HasMany(m => m.UpdatedPosts).WithOne(mt => mt.UpdatedByUser);

//            //builder
//            //    .HasMany(m => m.CreatedPresentations).WithOne(mt => mt.CreatedByUser);
//            //builder
//            //    .HasMany(m => m.UpdatedPresentations).WithOne(mt => mt.UpdatedByUser);


//            //builder
//            //    .HasMany(m => m.CreatedSponsors).WithOne(mt => mt.CreatedByUser);
//            //builder
//            //    .HasMany(m => m.UpdatedSponsors).WithOne(mt => mt.UpdatedByUser);
//        }
//    }
//}