using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Framework.src.Data
{
    public class AppDbContext
    {
        // In-memory storage for each entity type
        public List<User> Users { get; set; } = new List<User>();
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public List<Workspace> Workspaces { get; set; } = new List<Workspace>();
        public List<UserWorkspace> UserWorkspaces { get; set; } = new List<UserWorkspace>();

        public AppDbContext()
        {
            SeedData(); // Initialize with some dummy data
        }

        private void SeedData()
        {
            // Generate Users
            var user1 = new User("John", "Doe", "john.doe@example.com", "passwordHash");
            var user2 = new User("Jane", "Smith", "jane.smith@example.com", "passwordHash123");
            var user3 = new User("Michael", "Johnson", "michael.johnson@example.com", "securePass456");
            var user4 = new User("Emily", "Davis", "emily.davis@example.com", "hashedPassword789");
            var user5 = new User("Chris", "Brown", "chris.brown@example.com", "passHash321");
            var user6 = new User("Sophia", "Wilson", "sophia.wilson@example.com", "encryptedPass654");
            var user7 = new User("Daniel", "Martinez", "daniel.martinez@example.com", "hashedPass987");
            var user8 = new User("Olivia", "Garcia", "olivia.garcia@example.com", "passwordHash159");
            var user9 = new User("Matthew", "Anderson", "matthew.anderson@example.com", "hashPass753");
            Users.AddRange([user1, user2, user3, user4, user5, user6, user7, user8, user9]);

            // Generate Workspace
            var workspace1 = new Workspace("Marketing", user1.Id);
            var workspace2 = new Workspace("Development", user2.Id);
            var workspace3 = new Workspace("Design", user3.Id);
            var workspace4 = new Workspace("Sales", user4.Id);
            var workspace5 = new Workspace("HR", user5.Id);
            Workspaces.AddRange([workspace1, workspace2, workspace3, workspace4, workspace5]);

            // Generate tickets
            var ticket1 = new Ticket("Create Database", "using Postgres", PriorityEnum.High, DateTime.Now.AddDays(7), StatusEnum.InProgress, workspace1.Id, TicketTypeEnum.Bug);
            var ticket2 = new Ticket("Fix Login Issue", "Resolve authentication error", PriorityEnum.High, DateTime.Now.AddDays(3), StatusEnum.InProgress, workspace1.Id, TicketTypeEnum.Bug);
            var ticket3 = new Ticket("Design Landing Page", "Create wireframe for new landing page", PriorityEnum.Medium, DateTime.Now.AddDays(14), StatusEnum.Cancelled, workspace1.Id, TicketTypeEnum.Feature);
            var ticket4 = new Ticket("Update Privacy Policy", "Review and update policy document", PriorityEnum.Low, DateTime.Now.AddDays(30), StatusEnum.NotStarted, workspace2.Id, TicketTypeEnum.TechnicalDebt);
            var ticket5 = new Ticket("Optimize API", "Enhance performance of existing API calls", PriorityEnum.High, DateTime.Now.AddDays(10), StatusEnum.InProgress, workspace2.Id, TicketTypeEnum.Feature);
            var ticket6 = new Ticket("Schedule Training", "Plan onboarding session for new hires", PriorityEnum.Medium, DateTime.Now.AddDays(7), StatusEnum.NotStarted, workspace2.Id, TicketTypeEnum.TechnicalDebt);
            var ticket7 = new Ticket("Add Dark Mode", "Implement dark mode toggle for users", PriorityEnum.High, DateTime.Now.AddDays(21), StatusEnum.Cancelled, workspace3.Id, TicketTypeEnum.Bug);
            var ticket8 = new Ticket("Bug in Report Generation", "Fix issue with incorrect data rendering", PriorityEnum.High, DateTime.Now.AddDays(5), StatusEnum.InProgress, workspace4.Id, TicketTypeEnum.Feature);
            Tickets.AddRange([ticket1, ticket2, ticket3, ticket4, ticket5, ticket6, ticket7, ticket8]);

            // Generate user workspace
            // Project manager
            var userWorkspace1 = new UserWorkspace(user1.Id, workspace1.Id, RoleEnum.ProjectManager);
            var userWorkspace2 = new UserWorkspace(user2.Id, workspace2.Id, RoleEnum.ProjectManager);
            var userWorkspace3 = new UserWorkspace(user3.Id, workspace3.Id, RoleEnum.ProjectManager);

            // developer
            var userWorkspace4 = new UserWorkspace(user4.Id, workspace1.Id, RoleEnum.ProjectManager);
            var userWorkspace5 = new UserWorkspace(user5.Id, workspace1.Id, RoleEnum.ProjectManager);
            var userWorkspace6 = new UserWorkspace(user6.Id, workspace2.Id, RoleEnum.Developer);
            var userWorkspace7 = new UserWorkspace(user7.Id, workspace2.Id, RoleEnum.Developer);
        }

        // CRUD Simulation Methods
        public void Add<T>(T entity) where T : BaseEntity => GetDbSet<T>().Add(entity);
        public IEnumerable<T> GetAll<T>() where T : BaseEntity => GetDbSet<T>().AsEnumerable();
        public T? GetById<T>(Guid id) where T : BaseEntity => GetDbSet<T>().FirstOrDefault(e => e.Id == id);
        public void Update<T>(T entity) where T : BaseEntity
        {
            var dbSet = GetDbSet<T>();
            var existingEntity = dbSet.FirstOrDefault(e => e.Id == entity.Id);
            if (existingEntity != null)
            {
                dbSet.Remove(existingEntity);
                dbSet.Add(entity);
            }
        }

        public void Delete<T>(Guid id) where T : BaseEntity
        {
            var dbSet = GetDbSet<T>();
            var entity = dbSet.FirstOrDefault(e => e.Id == id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
        }

        private List<T> GetDbSet<T>() where T : BaseEntity
        {
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
    }
}