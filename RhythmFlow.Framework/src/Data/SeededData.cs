using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Framework.src.Data
{
    public static class DataSeeder
    {
        // password is "somepassword"
        private static readonly string Passhash = "$2a$11$2Nr99X5WZI2jTj1S4KLt9.INl4LRZwejVFdv/XegFA0cA6VhLbVFi";

        // Generate Users
        private static readonly User User1 = new ("John", "Doe", "john.doe@example.com", Passhash);
        private static readonly User User2 = new ("Jane", "Smith", "jane.smith@example.com", Passhash);
        private static readonly User User3 = new ("Michael", "Johnson", "michael.johnson@example.com", Passhash);
        private static readonly User User4 = new ("Emily", "Davis", "emily.davis@example.com", Passhash);
        private static readonly User User5 = new ("Chris", "Brown", "chris.brown@example.com", Passhash);
        private static readonly User User6 = new ("Sophia", "Wilson", "sophia.wilson@example.com", Passhash);
        private static readonly User User7 = new ("Daniel", "Martinez", "daniel.martinez@example.com", Passhash);
        private static readonly User User8 = new ("Olivia", "Garcia", "olivia.garcia@example.com", Passhash);
        private static readonly User User9 = new ("Matthew", "Anderson", "matthew.anderson@example.com", Passhash);

        // Generate Workspace
        private static readonly Workspace Workspace1 = new ("Marketing", User1.Id);
        private static readonly Workspace Workspace2 = new ("Development", User2.Id);
        private static readonly Workspace Workspace3 = new ("Design", User3.Id);
        private static readonly Workspace Workspace4 = new ("Sales", User4.Id);
        private static readonly Workspace Workspace5 = new ("HR", User5.Id);

        // Generate Project
        private static readonly Project Project1 = new ("Alpha", "Conquer the Galaxy", DateOnly.FromDateTime(DateTime.Now.AddDays(2)), DateOnly.FromDateTime(DateTime.Now.AddDays(50)), Status.InProgress, Workspace1.Id);
        private static readonly Project Project2 = new ("Beta", "Develop AI Assistant", DateOnly.FromDateTime(DateTime.Now.AddDays(5)), DateOnly.FromDateTime(DateTime.Now.AddDays(60)), Status.NotStarted, Workspace2.Id);
        private static readonly Project Project3 = new ("Gamma", "Revamp Website Design", DateOnly.FromDateTime(DateTime.Now.AddDays(3)), DateOnly.FromDateTime(DateTime.Now.AddDays(45)), Status.InProgress, Workspace3.Id);
        private static readonly Project Project4 = new ("Delta", "Launch Mobile App", DateOnly.FromDateTime(DateTime.Now.AddDays(7)), DateOnly.FromDateTime(DateTime.Now.AddDays(90)), Status.InProgress, Workspace4.Id);
        private static readonly Project Project5 = new ("Epsilon", "Implement Cloud Migration", DateOnly.FromDateTime(DateTime.Now.AddDays(1)), DateOnly.FromDateTime(DateTime.Now.AddDays(120)), Status.Cancelled, Workspace5.Id);
        private static readonly Project Project6 = new ("Zeta", "Optimize Data Pipeline", DateOnly.FromDateTime(DateTime.Now.AddDays(10)), DateOnly.FromDateTime(DateTime.Now.AddDays(80)), Status.InProgress, Workspace5.Id);

        // Generate tickets
        // Project 1
        private static readonly Ticket Ticket1 = new ("Create Database", "using Postgres", Priority.High, DateOnly.FromDateTime(DateTime.Now.AddDays(7)), Status.InProgress, Project1.Id, TicketType.Bug);
        private static readonly Ticket Ticket2 = new ("Fix Login Issue", "Resolve authentication error", Priority.High, DateOnly.FromDateTime(DateTime.Now.AddDays(3)), Status.InProgress, Project1.Id, TicketType.Bug);
        private static readonly Ticket Ticket3 = new ("Design Landing Page", "Create wireframe for new landing page", Priority.Medium, DateOnly.FromDateTime(DateTime.Now.AddDays(14)), Status.Cancelled, Project1.Id, TicketType.Feature);

        // Project 2
        private static readonly Ticket Ticket4 = new ("Update Privacy Policy", "Review and update policy document", Priority.Low, DateOnly.FromDateTime(DateTime.Now.AddDays(30)), Status.NotStarted, Project2.Id, TicketType.TechnicalDebt);
        private static readonly Ticket Ticket5 = new ("Optimize API", "Enhance performance of existing API calls", Priority.High, DateOnly.FromDateTime(DateTime.Now.AddDays(10)), Status.InProgress, Project2.Id, TicketType.Feature);
        private static readonly Ticket Ticket6 = new ("Schedule Training", "Plan onboarding session for new hires", Priority.Medium, DateOnly.FromDateTime(DateTime.Now.AddDays(7)), Status.NotStarted, Project2.Id, TicketType.TechnicalDebt);

        // Project 5
        private static readonly Ticket Ticket7 = new ("Add Dark Mode", "Implement dark mode toggle for Users", Priority.High, DateOnly.FromDateTime(DateTime.Now.AddDays(21)), Status.Cancelled, Project5.Id, TicketType.Bug);

        // Project 6
        private static readonly Ticket Ticket8 = new ("Bug in Report Generation", "Fix issue with incorrect data rendering", Priority.High, DateOnly.FromDateTime(DateTime.Now.AddDays(5)), Status.InProgress, Project6.Id, TicketType.Feature);

        // Generate User workspace
        // Project manager
        private static readonly UserWorkspace UserWorkspace1 = new (User1.Id, Workspace1.Id, Role.ProjectManager);
        private static readonly UserWorkspace UserWorkspace2 = new (User2.Id, Workspace2.Id, Role.ProjectManager);
        private static readonly UserWorkspace UserWorkspace3 = new (User3.Id, Workspace3.Id, Role.ProjectManager);

        // developer
        private static readonly UserWorkspace UserWorkspace4 = new (userId: User4.Id, workspaceId: Workspace1.Id, Role.ProjectManager);
        private static readonly UserWorkspace UserWorkspace5 = new (User9.Id, Workspace1.Id, Role.ProjectManager);
        private static readonly UserWorkspace UserWorkspace6 = new (User6.Id, Workspace2.Id, Role.Developer);
        private static readonly UserWorkspace UserWorkspace7 = new (User7.Id, Workspace2.Id, Role.Developer);

        public static void Seed(ModelBuilder modelBuilder)
        {
            // Users
            // we have to do it like this due to https://github.com/dotnet/efcore/issues/9914
            modelBuilder.Entity<User>(x =>
            {
                x.HasData(new { User1.Id, User1.FirstName, User1.LastName, User1.PasswordHash });
                x.OwnsOne(e => e.Email).HasData(new { UserId = User1.Id, User1.Email.Value });
            });
            modelBuilder.Entity<User>(x =>
            {
                x.HasData(new { User2.Id, User2.FirstName, User2.LastName, User2.PasswordHash });
                x.OwnsOne(e => e.Email).HasData(new { UserId = User2.Id, User2.Email.Value });
            });

            modelBuilder.Entity<User>(x =>
            {
                x.HasData(new { User3.Id, User3.FirstName, User3.LastName, User3.PasswordHash });
                x.OwnsOne(e => e.Email).HasData(new { UserId = User3.Id, User3.Email.Value });
            });

            modelBuilder.Entity<User>(x =>
            {
                x.HasData(new { User4.Id, User4.FirstName, User4.LastName, User4.PasswordHash });
                x.OwnsOne(e => e.Email).HasData(new { UserId = User4.Id, User4.Email.Value });
            });

            modelBuilder.Entity<User>(x =>
            {
                x.HasData(new { User5.Id, User5.FirstName, User5.LastName, User5.PasswordHash });
                x.OwnsOne(e => e.Email).HasData(new { UserId = User5.Id, User5.Email.Value });
            });

            modelBuilder.Entity<User>(x =>
            {
                x.HasData(new { User6.Id, User6.FirstName, User6.LastName, User6.PasswordHash });
                x.OwnsOne(e => e.Email).HasData(new { UserId = User6.Id, User6.Email.Value });
            });

            modelBuilder.Entity<User>(x =>
            {
                x.HasData(new { User7.Id, User7.FirstName, User7.LastName, User7.PasswordHash });
                x.OwnsOne(e => e.Email).HasData(new { UserId = User7.Id, User7.Email.Value });
            });

            modelBuilder.Entity<User>(x =>
            {
                x.HasData(new { User8.Id, User8.FirstName, User8.LastName, User8.PasswordHash });
                x.OwnsOne(e => e.Email).HasData(new { UserId = User8.Id, User8.Email.Value });
            });

            modelBuilder.Entity<User>(x =>
            {
                x.HasData(new { User9.Id, User9.FirstName, User9.LastName, User9.PasswordHash });
                x.OwnsOne(e => e.Email).HasData(new { UserId = User9.Id, User9.Email.Value });
            });

            // Other entities
            modelBuilder.Entity<Workspace>().HasData(Workspace1, Workspace2, Workspace3, Workspace4, Workspace5);
            modelBuilder.Entity<Project>().HasData(Project1, Project2, Project3, Project4, Project5, Project6);
            modelBuilder.Entity<Ticket>().HasData(Ticket1, Ticket2, Ticket3, Ticket4, Ticket5, Ticket6, Ticket7, Ticket8);

            // UserWorkspace
            modelBuilder.Entity<UserWorkspace>().HasData(UserWorkspace1, UserWorkspace2, UserWorkspace3, UserWorkspace4, UserWorkspace5, UserWorkspace6, UserWorkspace7);
        }
    }
}