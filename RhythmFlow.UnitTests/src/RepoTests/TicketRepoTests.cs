using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Data;
using RhythmFlow.Framework.src.Repo;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.RepoTests
{
    public class TicketRepoTests
    {
        private AppDbContext CreateInMemoryDbContextOptions()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new AppDbContext(options);
        }

        [Fact]
        public async Task GetAllTicketsInProjectAsync_ReturnsTicketsInProject()
        {
            // Arrange
            using var context = CreateInMemoryDbContextOptions();
            var ticketRepo = new TicketRepo(context);
            var projectRepo = new ProjectRepo(context);
            var userRepo = new UserRepo(context);
            var userWorkspaceRepo = new UserWorkspaceRepo(context);
            var workSpaceRepo = new WorkspaceRepo(context, userWorkspaceRepo);
            var user2 = new TestUser("Monsi", "Phonsi", "jones@pence.com", "fdgfsfds213!");
            var testWorkspace = new TestWorkSpace("Health", user2.Id);
            var project = new TestProject("Health Application", "bla bla bla", new DateOnly(2025, 2, 2), new DateOnly(2026, 2, 2), Status.NotStarted, testWorkspace.Id);
            await userRepo.AddAsync(user2);
            await workSpaceRepo.AddAsync(testWorkspace);
            await projectRepo.AddAsync(project);
            var ticket1 = new TestTicket("Create Database", "Create a database for the application", Priority.High, new DateOnly(2025, 4, 5), Status.NotStarted, project.Id, TicketType.Feature);
            var ticket2 = new TestTicket("Create Controller", "Create Controller for hight", Priority.High, new DateOnly(2025, 4, 5), Status.NotStarted, project.Id, TicketType.Feature);
            await ticketRepo.AddAsync(ticket1);
            await ticketRepo.AddAsync(ticket2);
            await context.SaveChangesAsync();

            // Act
            var result = await ticketRepo.GetAllTicketsInProjectAsync(project.Id);

            // Assert
            Assert.Equal(2, result.Count());
            Assert.Equal(project.Id, result.First().ProjectId);
        }
    }
}