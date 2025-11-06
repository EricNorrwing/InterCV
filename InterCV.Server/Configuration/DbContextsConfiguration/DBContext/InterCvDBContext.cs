using InterCV.Server.Models;
using InterCV.Server.Models.CvModels.CvJunctionTables;
using InterCV.Server.Models.CvModels.Educations;
using InterCV.Server.Models.CvModels.Experiences;
using InterCV.Server.Models.CvModels.Experiences.References;
using InterCV.Server.Models.CvModels.Tags;
using InterCV.Server.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace InterCV.Server.Configuration.DbContextsConfiguration.DBContext;

public class InterCvDbContext(DbContextOptions<InterCvDbContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<AuthUser> AuthUsers => Set<AuthUser>();
    public DbSet<UserProfile> UserProfiles => Set<UserProfile>();

    public DbSet<Cv> Cvs => Set<Cv>();

    public DbSet<Experience> Experiences => Set<Experience>();
    public DbSet<Achievement> Achievements => Set<Achievement>();
    public DbSet<Reference> References => Set<Reference>();

    public DbSet<Education> Educations => Set<Education>();

    public DbSet<Tag> Tags => Set<Tag>();

    public DbSet<CvExperience> CvExperiences => Set<CvExperience>();
    public DbSet<CvEducation> CvEducations => Set<CvEducation>();
    public DbSet<CvTag> CvTags => Set<CvTag>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasOne(u => u.Auth)
            .WithOne(a => a.User)
            .HasForeignKey<AuthUser>(a => a.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<User>()
            .HasOne(u => u.Profile)
            .WithOne(p => p.User)
            .HasForeignKey<UserProfile>(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<User>()
            .HasMany(u => u.Cvs)
            .WithOne(c => c.User)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<User>()
            .HasMany(u => u.Experiences)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<User>()
            .HasMany(u => u.Educations)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Experience>()
            .HasMany(e => e.Achievements)
            .WithOne(a => a.Experience)
            .HasForeignKey(a => a.ExperienceId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Experience>()
            .HasMany(e => e.References)
            .WithOne(r => r.Experience)
            .HasForeignKey(r => r.ExperienceId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CvExperience>()
            .HasKey(ce => new { ce.CvId, ce.ExperienceId });

        modelBuilder.Entity<CvExperience>()
            .HasOne(ce => ce.Cv)
            .WithMany(c => c.Experiences)
            .HasForeignKey(ce => ce.CvId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CvExperience>()
            .HasOne(ce => ce.Experience)
            .WithMany()
            .HasForeignKey(ce => ce.ExperienceId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CvEducation>()
            .HasKey(ce => new { ce.CvId, ce.EducationId });

        modelBuilder.Entity<CvEducation>()
            .HasOne(ce => ce.Cv)
            .WithMany(c => c.Educations)
            .HasForeignKey(ce => ce.CvId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CvEducation>()
            .HasOne(ce => ce.Education)
            .WithMany()
            .HasForeignKey(ce => ce.EducationId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CvTag>()
            .HasKey(ct => new { ct.CvId, ct.TagId });

        modelBuilder.Entity<CvTag>()
            .HasOne(ct => ct.Cv)
            .WithMany(c => c.Tags)
            .HasForeignKey(ct => ct.CvId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CvTag>()
            .HasOne(ct => ct.Tag)
            .WithMany()
            .HasForeignKey(ct => ct.TagId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Education>()
            .Property(e => e.Type)
            .HasConversion<string>();
    }
}
