using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Framework.src.Data
{
    public class AppDbContext() : DbContext()
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // In-memory storage for each entity type
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Workspace> Workspaces { get; set; }
        public DbSet<UserWorkspace> UserWorkspaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // more here: https://stackoverflow.com/questions/78836133/net-entity-framework-core-database-update-fails-with-host-cant-be-null
            //if (!optionsBuilder.IsConfigured) // Only configure if no options are already provided
       //     {
                var _configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
                optionsBuilder
                .UseNpgsql(_configuration.GetConnectionString("DefaultConnection"))
                .EnableDetailedErrors() // not in production
                .EnableSensitiveDataLogging() // not in production
                .UseSnakeCaseNamingConvention();
         //   }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // EF Core does not support owned entity to be checked for uniqueness yet, so we have to do it ourselves
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(user => user.FirstName).HasColumnName("first_name").IsRequired();
                entity.Property(user => user.LastName).HasColumnName("last_name").IsRequired();
                entity.OwnsOne(user => user.Email, email =>
                {
                    email.Property(s => s.Value).HasColumnName("user_email").IsRequired();
                });
            });
            modelBuilder.Entity<UserWorkspace>().HasKey(uw => new { uw.UserId, uw.WorkspaceId });

            // convert Project enum type to string
            modelBuilder.Entity<Project>()
                .Property(e => e.Status)
                .HasConversion(
                    v => v.ToString(),
                    v => (Status)Enum.Parse(typeof(Status), v));

            // convert Ticket enum type to tring
            modelBuilder.Entity<Ticket>()
                .Property(e => e.Status)
                .HasConversion(
                    v => v.ToString(),
                    v => (Status)Enum.Parse(typeof(Status), v)); // convert enum type to string
            modelBuilder.Entity<Ticket>()
                .Property(e => e.Priority)
                .HasConversion(
                    v => v.ToString(),
                    v => (Priority)Enum.Parse(typeof(Priority), v)); // convert enum type to string

            DataSeeder.Seed(modelBuilder);
        }

        public User? GetUserByEmail(Email email)
        {
            var user = Users.FirstOrDefault(u => u.Email.Value == email.Value);
            return user;
        }

        public UserWorkspace? GetUserWorkspaceByUserIdAndWorkspaceId(Guid userId, Guid workspaceId)
        {
            return UserWorkspaces.FirstOrDefault(uw => uw.UserId == userId && uw.WorkspaceId == workspaceId);
        }

        public IEnumerable<Workspace> GetWorkspacesJoinedByUserId(Guid userId)
        {
            var userWorkspaces = UserWorkspaces.Where(uw => uw.UserId == userId).ToList();
            var workSpaces = Workspaces.Where(w => userWorkspaces.Select(uw => uw.WorkspaceId).Equals(w.Id)).ToList();
            return workSpaces;
        }

        public IEnumerable<Workspace> GetWorkspacesOwnedByUser(Guid userId)
        {
            var workSpaces = Workspaces.Where(w => w.OwnerId == userId).ToList();
            return workSpaces;
        }
    }
}