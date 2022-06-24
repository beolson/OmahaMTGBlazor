using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using OmahaMRG.Application;
using OmahaMRG.Application.Common.Enum;
using OmahaMRG.Application.Common.Interfaces;
using OmahaMRG.Application.Entities;
using OmahaMRG.Application.Entities.Common;
using System.Reflection;

namespace OmahaMTG.Infrastructure.Persistence
{
    internal class ApplicationDbContext : IdentityDbContext<OmahaMtgUser>, IApplicationDbContext
    {
        private readonly ILoggerFactory _loggerFactory;
        //private readonly ITimeUtility _timeUtility;
        //private readonly UserContext _userContext;

        public ApplicationDbContext(DbContextOptions options, ILoggerFactory loggerFactory) :
            base(options)
        {
            //_userContext = userContext;
            //_timeUtility = timeUtility;
            _loggerFactory = loggerFactory;
        }

        //public DbSet<Meeting> Meetings => Set<Meeting>();
        //public DbSet<MeetingRsvp> MeetingRsvps => Set<MeetingRsvp>();
        //public DbSet<MeetingSponsor> MeetingSponsors => Set<MeetingSponsor>();
        //public DbSet<MeetingTag> MeetingTags => Set<MeetingTag>();
        public DbSet<Post> Posts => Set<Post>();
        //public DbSet<Supporter> Supporters => Set<Supporter>();
        public DbSet<PostTag> PostTags => Set<PostTag>();
        //public DbSet<Presentation> Presentations => Set<Presentation>();
        //public DbSet<Presenter> Presenters => Set<Presenter>();
        //public DbSet<PresentationPresenter> PresentationPresenters => Set<PresentationPresenter>();

        public DbSet<Tag> Tags => Set<Tag>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLoggerFactory(_loggerFactory);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //builder.Entity<IdentityRole>().HasData(new IdentityRole
            //{
            //    Id = "admin",
            //    Name = "admin",
            //    NormalizedName = "admin"
            //});


            //https://stackoverflow.com/questions/50375357/how-to-create-a-table-corresponding-to-enum-in-ef-core-code-first
            //builder
            //    .Entity<OmahaMtgUser>()
            //    .Property(e => e.role)
            //    .HasConversion<int>();

            //builder
            //    .Entity<WineVariant>()
            //    .Property(e => e.WineVariantId)
            //    .HasConversion<int>();

            builder
                .Entity<IdentityRole>().HasData(
                    Enum.GetValues(typeof(ApplicationRoles))
                        .Cast<ApplicationRoles>()
                        .Select(e => new IdentityRole
                        {
                            Id = e.ToString(),
                            Name = e.ToString(),
                            NormalizedName = e.ToString()
                        })
                );
        }

        //public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
        //    CancellationToken cancellationToken = new())
        //{
        //    string currentUserId = string.Empty;

        //    if (_userContext.IsLoggedIn)
        //    {
        //        currentUserId = _userContext.UserId;
        //    }

        //    IEnumerable<EntityEntry> modifiedEntries = ChangeTracker.Entries()
        //        .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);

        //    // var now = _timeUtility.CurrentTime();

        //    foreach (EntityEntry entry in modifiedEntries)
        //    {
        //        if (entry.Entity is AuditableEntity entity)
        //        {
        //            if (entry.State == EntityState.Added)
        //            {
        //                entity.CreatedByUserId = currentUserId;
        //                entity.CreatedDate = _timeUtility.GetCurrentSystemTime();
        //            }

        //            entity.UpdatedByUserId = currentUserId;
        //            entity.UpdatedDate = _timeUtility.GetCurrentSystemTime();
        //        }
        //    }


        //    return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        //}

        //public override int SaveChanges()
        //{
        //    string currentUserId = string.Empty;

        //    if (_userContext.IsLoggedIn)
        //    {
        //        currentUserId = _userContext.UserId;
        //    }


        //    IEnumerable<EntityEntry> modifiedEntries = ChangeTracker.Entries()
        //        .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);

        //    //var now = _timeUtility.CurrentTime();

        //    foreach (EntityEntry entry in modifiedEntries)
        //    {
        //        if (entry.Entity is AuditableEntity entity)
        //        {
        //            if (entry.State == EntityState.Added)
        //            {
        //                entity.CreatedByUserId = currentUserId;
        //            }
        //            //   entity.CreatedDate = now;

        //            entity.UpdatedByUserId = currentUserId;
        //            // entity.UpdatedDate = now;
        //        }
        //    }


        //    return base.SaveChanges();
        //}
    }
}