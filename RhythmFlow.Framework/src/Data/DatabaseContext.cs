using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Framework.src.Data
{
    public class AppDbContext
    {
        // In-memory storage for each entity type
        public List<User> Users { get; set; } = [];
        public List<Project> Projects { get; set; } = [];
        public List<Ticket> Tickets { get; set; } = [];
        public List<Workspace> Workspaces { get; set; } = [];
        public List<UserWorkspace> UserWorkspaces { get; set; } = [];

        private static readonly object _lock = new ();

        public static AppDbContext Instance
        {
            get
            {
                lock (_lock)
                {
                    _instance ??= new AppDbContext();
                    return _instance;
                }
            }
        }

        private static AppDbContext? _instance;

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

            // unhashed password for the test user10 is "secretpassword"
            var user10 = new User("Emma", "Taylor", "user@email.com", "$2a$11$fakeQIXtM.1cvBZ5oFy6n.70UqvVCoz5bdSFIqWiUdNEvtr1wzmtW", Guid.Parse("85e00eb3-0c38-4b8e-94f8-dea41f297bec"));
            Users.AddRange([user1, user2, user3, user4, user5, user6, user7, user8, user9, user10]);

            // Generate Workspace
            var workspace1 = new Workspace("Marketing", user1.Id);
            var workspace2 = new Workspace("Development", user2.Id);
            var workspace3 = new Workspace("Design", user3.Id);
            var workspace4 = new Workspace("Sales", user4.Id);
            var workspace5 = new Workspace("HR", user5.Id);

            // Workspace with explicit id for testing
            var workspace6 = new Workspace("Testing", user6.Id, Guid.Parse("00045000-5400-0080-4000-000000006906"));
            Workspaces.AddRange([workspace1, workspace2, workspace3, workspace4, workspace5, workspace6]);

            // Generate Project
            var project1 = new Project("Alpha", "Conquer the Galaxy", DateTime.Now.AddDays(2), DateTime.Now.AddDays(50), Status.InProgress, workspace1.Id);
            var project2 = new Project("Beta", "Develop AI Assistant", DateTime.Now.AddDays(5), DateTime.Now.AddDays(60), Status.NotStarted, workspace2.Id);
            var project3 = new Project("Gamma", "Revamp Website Design", DateTime.Now.AddDays(3), DateTime.Now.AddDays(45), Status.InProgress, workspace3.Id);
            var project4 = new Project("Delta", "Launch Mobile App", DateTime.Now.AddDays(7), DateTime.Now.AddDays(90), Status.InProgress, workspace4.Id);
            var project5 = new Project("Epsilon", "Implement Cloud Migration", DateTime.Now.AddDays(1), DateTime.Now.AddDays(120), Status.Cancelled, workspace5.Id);
            var project6 = new Project("Zeta", "Optimize Data Pipeline", DateTime.Now.AddDays(10), DateTime.Now.AddDays(80), Status.InProgress, workspace6.Id);
            Projects.AddRange([project1, project2, project3, project4, project5, project6]);

            // Generate tickets
            var ticket1 = new Ticket("Create Database", "using Postgres", Priority.High, DateTime.Now.AddDays(7), Status.InProgress, project1.Id, TicketType.Bug);
            var ticket2 = new Ticket("Fix Login Issue", "Resolve authentication error", Priority.High, DateTime.Now.AddDays(3), Status.InProgress, project1.Id, TicketType.Bug);
            var ticket3 = new Ticket("Design Landing Page", "Create wireframe for new landing page", Priority.Medium, DateTime.Now.AddDays(14), Status.Cancelled, project1.Id, TicketType.Feature);
            var ticket4 = new Ticket("Update Privacy Policy", "Review and update policy document", Priority.Low, DateTime.Now.AddDays(30), Status.NotStarted, project2.Id, TicketType.TechnicalDebt);
            var ticket5 = new Ticket("Optimize API", "Enhance performance of existing API calls", Priority.High, DateTime.Now.AddDays(10), Status.InProgress, project5.Id, TicketType.Feature);
            var ticket6 = new Ticket("Schedule Training", "Plan onboarding session for new hires", Priority.Medium, DateTime.Now.AddDays(7), Status.NotStarted, project6.Id, TicketType.TechnicalDebt);
            var ticket7 = new Ticket("Add Dark Mode", "Implement dark mode toggle for users", Priority.High, DateTime.Now.AddDays(21), Status.Cancelled, project6.Id, TicketType.Bug);
            var ticket8 = new Ticket("Bug in Report Generation", "Fix issue with incorrect data rendering", Priority.High, DateTime.Now.AddDays(5), Status.InProgress, project6.Id, TicketType.Feature);
            Tickets.AddRange([ticket1, ticket2, ticket3, ticket4, ticket5, ticket6, ticket7, ticket8]);

            // Generate user workspace
            // Project manager
            var userWorkspace1 = new UserWorkspace(user1.Id, workspace1.Id, Role.ProjectManager);
            var userWorkspace2 = new UserWorkspace(user2.Id, workspace2.Id, Role.ProjectManager);
            var userWorkspace3 = new UserWorkspace(user3.Id, workspace3.Id, Role.ProjectManager);

            // One for authorisation testing
            var userWorkspace8 = new UserWorkspace(user10.Id, workspace6.Id, Role.ProjectManager); // change the role as needed for manual testing

            // developer
            var userWorkspace4 = new UserWorkspace(user4.Id, workspace1.Id, Role.ProjectManager);
            var userWorkspace5 = new UserWorkspace(user5.Id, workspace1.Id, Role.ProjectManager);
            var userWorkspace6 = new UserWorkspace(user6.Id, workspace2.Id, Role.Developer);
            var userWorkspace7 = new UserWorkspace(user7.Id, workspace2.Id, Role.Developer);
            UserWorkspaces.AddRange([userWorkspace1, userWorkspace2, userWorkspace3, userWorkspace4, userWorkspace5, userWorkspace6, userWorkspace7, userWorkspace8]);

            // assign test user to projects
            project6.Users = [user10];
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

        public User? GetUserByEmail(Email email)
        {
            var user = Users.Find(u => u.Email.Value == email.Value);
            return user;
        }

        public UserWorkspace? GetUserWorkspaceByUserIdAndWorkspaceId(Guid userId, Guid workspaceId)
        {
            Console.WriteLine($"userId: {userId}, workspaceId: {workspaceId}");
            Console.WriteLine(UserWorkspaces.Last().UserId);
            Console.WriteLine(UserWorkspaces.Last().WorkspaceId);
            Console.WriteLine(UserWorkspaces.Last().Role);
            return UserWorkspaces.Find(uw => uw.UserId == userId && uw.WorkspaceId == workspaceId);
        }

        private List<T> GetDbSet<T>()
            where T : BaseEntity
        {
            // cannot use switch here
#pragma warning disable CS8603 // Possible null reference return.
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
#pragma warning restore CS8603 // Possible null reference return.
            throw new InvalidOperationException("Invalid entity type");
        }
    }
}