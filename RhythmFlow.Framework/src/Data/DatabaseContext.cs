using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Framework.src.Data
{
    public class AppDbContext() : DbContext()
    {
        // In-memory storage for each entity type
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Workspace> Workspaces { get; set; }
        public DbSet<UserWorkspace> UserWorkspaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // more here: https://stackoverflow.com/questions/78836133/net-entity-framework-core-database-update-fails-with-host-cant-be-null
            var _configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
            optionsBuilder
            .UseNpgsql(_configuration.GetConnectionString("DefaultConnection"))
            .EnableDetailedErrors() // not in production
            .EnableSensitiveDataLogging() // not in production
            .UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.OwnsOne(user => user.Email, email =>
                {
                    email.Property(s => s.Value).HasColumnName("user_email").IsRequired();
                });
            });

            // modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
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
        }

        // CRUD Simulation Methods
        public void Add<T>(T entity)
            where T : BaseEntity
        {
            GetDbSet<T>().Add(entity);
        }

        public IEnumerable<T> GetAll<T>()
                    where T : BaseEntity
        {
            return GetDbSet<T>().AsEnumerable();
        }

        public T? GetById<T>(Guid id)
                    where T : BaseEntity
        {
            return GetDbSet<T>()?.Find(e => e.Id == id);
        }

        public void Update<T>(T entity)
            where T : BaseEntity
        {
            var dbSet = GetDbSet<T>();
            var existingEntity = dbSet.Find(e => e.Id == entity.Id);
            if (existingEntity != null)
            {
                dbSet.Remove(existingEntity);
                dbSet.Add(entity);
            }
        }

        public void Delete<T>(Guid id)
            where T : BaseEntity
        {
            var dbSet = GetDbSet<T>();
            var entity = dbSet.Find(e => e.Id == id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
        }

#pragma warning disable CS8603 // Possible null reference return.
        public User? GetUserByEmail(Email email)
        {
            // var user = Users.Find(u => u.Email.Value == email.Value);
            // return user;
            return null;
        }

        public UserWorkspace? GetUserWorkspaceByUserIdAndWorkspaceId(Guid userId, Guid workspaceId)
        {
            Console.WriteLine($"userId: {userId}, workspaceId: {workspaceId}");
            Console.WriteLine(UserWorkspaces.Last().UserId);
            Console.WriteLine(UserWorkspaces.Last().WorkspaceId);
            Console.WriteLine(UserWorkspaces.Last().Role);

            // return UserWorkspaces.Find(uw => uw.UserId == userId && uw.WorkspaceId == workspaceId);
            return null;
        }

        private List<T> GetDbSet<T>()
            where T : BaseEntity
        {
            // cannot use switch here
            if (typeof(T) == typeof(User))
                return Users as List<T>;

            if (typeof(T) == typeof(Project))
                return Projects as List<T>;
            if (typeof(T) == typeof(Ticket))
                return Tickets as List<T>;
            if (typeof(T) == typeof(Workspace))
                return Workspaces as List<T>;
            if (typeof(T) == typeof(UserWorkspace))
                return UserWorkspaces as List<T>;

            throw new InvalidOperationException("Invalid entity type");
        }
#pragma warning restore CS8603 // Possible null reference return.
    }
}