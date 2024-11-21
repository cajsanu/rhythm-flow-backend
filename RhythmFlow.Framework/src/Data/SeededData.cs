using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Framework.src.Data
{
    public static class DataSeeder
    {
        // Generate Users
        private static readonly User User1 = new ("John", "Doe", "john.doe@example.com", "passwordHash");
        private static readonly User User2 = new ("Jane", "Smith", "jane.smith@example.com", "passwordHash123");
        private static readonly User User3 = new ("Michael", "Johnson", "michael.johnson@example.com", "securePass456");
        private static readonly User User4 = new ("Emily", "Davis", "emily.davis@example.com", "hashedPassword789");
        private static readonly User User5 = new ("Chris", "Brown", "chris.brown@example.com", "passHash321");
        private static readonly User User6 = new ("Sophia", "Wilson", "sophia.wilson@example.com", "encryptedPass654");
        private static readonly User User7 = new ("Daniel", "Martinez", "daniel.martinez@example.com", "hashedPass987");
        private static readonly User User8 = new ("Olivia", "Garcia", "olivia.garcia@example.com", "passwordHash159");
        private static readonly User User9 = new ("Matthew", "Anderson", "matthew.anderson@example.com", "hashPass753");
        // Users.AddRange([User1, User2, User3, User4, User5, User6, User7, User8, User9]);

        // Generate Workspace
        private static readonly Workspace Workspace1 = new ("Marketing", User1.Id);
        private static readonly Workspace Workspace2 = new ("Development", User2.Id);
        private static readonly Workspace Workspace3 = new ("Design", User3.Id);
        private static readonly Workspace Workspace4 = new ("Sales", User4.Id);
        private static readonly Workspace Workspace5 = new ("HR", User5.Id);
        // Workspaces.AddRange([workspace1, workspace2, workspace3, workspace4, workspace5]);

        // Generate Project
        private static readonly Project Project1 = new ("Alpha", "Conquer the Galaxy", DateTime.Now.AddDays(2), DateTime.Now.AddDays(50), Status.InProgress, Workspace1.Id);
        private static readonly Project Project2 = new ("Beta", "Develop AI Assistant", DateTime.Now.AddDays(5), DateTime.Now.AddDays(60), Status.NotStarted, Workspace2.Id);
        private static readonly Project Project3 = new ("Gamma", "Revamp Website Design", DateTime.Now.AddDays(3), DateTime.Now.AddDays(45), Status.InProgress, Workspace3.Id);
        private static readonly Project Project4 = new ("Delta", "Launch Mobile App", DateTime.Now.AddDays(7), DateTime.Now.AddDays(90), Status.InProgress, Workspace4.Id);
        private static readonly Project Project5 = new ("Epsilon", "Implement Cloud Migration", DateTime.Now.AddDays(1), DateTime.Now.AddDays(120), Status.Cancelled, Workspace5.Id);
        private static readonly Project Project6 = new ("Zeta", "Optimize Data Pipeline", DateTime.Now.AddDays(10), DateTime.Now.AddDays(80), Status.InProgress, Workspace5.Id);
        // Projects.AddRange([project1, project2, project3, project4, project5, project6]);

        // Generate tickets
        private static readonly Ticket Ticket1 = new ("Create Database", "using Postgres", Priority.High, DateTime.Now.AddDays(7), Status.InProgress, Project1.Id, TicketType.Bug);
        private static readonly Ticket Ticket2 = new ("Fix Login Issue", "Resolve authentication error", Priority.High, DateTime.Now.AddDays(3), Status.InProgress, Project1.Id, TicketType.Bug);
        private static readonly Ticket Ticket3 = new ("Design Landing Page", "Create wireframe for new landing page", Priority.Medium, DateTime.Now.AddDays(14), Status.Cancelled, Project1.Id, TicketType.Feature);
        private static readonly Ticket Ticket4 = new ("Update Privacy Policy", "Review and update policy document", Priority.Low, DateTime.Now.AddDays(30), Status.NotStarted, Project2.Id, TicketType.TechnicalDebt);
        private static readonly Ticket Ticket5 = new ("Optimize API", "Enhance performance of existing API calls", Priority.High, DateTime.Now.AddDays(10), Status.InProgress, Project2.Id, TicketType.Feature);
        private static readonly Ticket Ticket6 = new ("Schedule Training", "Plan onboarding session for new hires", Priority.Medium, DateTime.Now.AddDays(7), Status.NotStarted, Project2.Id, TicketType.TechnicalDebt);
        private static readonly Ticket Ticket7 = new ("Add Dark Mode", "Implement dark mode toggle for Users", Priority.High, DateTime.Now.AddDays(21), Status.Cancelled, Project5.Id, TicketType.Bug);
        private static readonly Ticket Ticket8 = new ("Bug in Report Generation", "Fix issue with incorrect data rendering", Priority.High, DateTime.Now.AddDays(5), Status.InProgress, Project6.Id, TicketType.Feature);
        // Tickets.AddRange([ticket1, ticket2, ticket3, ticket4, ticket5, ticket6, ticket7, ticket8]);

        // Generate User workspace
        // Project manager
        private static readonly UserWorkspace UserWorkspace1 = new (User1.Id, Workspace1.Id, Role.ProjectManager);
        private static readonly UserWorkspace UserWorkspace2 = new (User2.Id, Workspace2.Id, Role.ProjectManager);
        private static readonly UserWorkspace UserWorkspace3 = new (User3.Id, Workspace3.Id, Role.ProjectManager);

        // developer
        private static readonly UserWorkspace UserWorkspace4 = new (User4.Id, Workspace1.Id, Role.ProjectManager);
        private static readonly UserWorkspace UserWorkspace5 = new (User1.Id, Workspace1.Id, Role.ProjectManager);
        private static readonly UserWorkspace UserWorkspace6 = new (User6.Id, Workspace2.Id, Role.Developer);
        private static readonly UserWorkspace UserWorkspace7 = new (User7.Id, Workspace2.Id, Role.Developer);
        // UserWorkspaces.AddRange([UserWorkspace1, UserWorkspace2, UserWorkspace3, UserWorkspace4, UserWorkspace5, UserWorkspace6, UserWorkspace7]);

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(User1, User2, User3, User4, User5, User6, User7, User8, User9);
            modelBuilder.Entity<Workspace>().HasData(Workspace1, Workspace2, Workspace3, Workspace4, Workspace5);
            modelBuilder.Entity<Project>().HasData(Project1, Project2, Project3, Project4, Project5, Project6);
            modelBuilder.Entity<Ticket>().HasData(Ticket1, Ticket2, Ticket3, Ticket4, Ticket5, Ticket6, Ticket7, Ticket8);

            modelBuilder.Entity<UserWorkspace>().HasData(UserWorkspace1, UserWorkspace2, UserWorkspace3, UserWorkspace4, UserWorkspace5, UserWorkspace6, UserWorkspace7);
        }
    }
}