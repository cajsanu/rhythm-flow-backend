using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Data;
using RhythmFlow.Framework.src.Repo;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.RepoTests
{
    public class ProjectRepoTest
    {
        private AppDbContext CreateInMemoryDbContextOptions()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new AppDbContext(options);
        }
        [Fact]
        public async Task GetAllProjectsInWorkspaceAsync_ReturnsProjectsInWorkspace()
        {
            using var context = CreateInMemoryDbContextOptions();
            var projectRepo = new ProjectRepo(context);
            var workSpaceRepo = new BaseRepo<Workspace>(context);
            var userRepo = new BaseRepo<User>(context);
            var user = new TestUser("Monsi", "Phonsi", "jones@pence.com", "fdgfsfds213!");
            var testWorkspace = new TestWorkSpace("Health", user.Id);
            var project = new TestProject("Health Application", "bla bla bla", new DateOnly(2025, 2, 2), new DateOnly(2026, 2, 2), Status.NotStarted, testWorkspace.Id);
            var project2 = new TestProject("Travel Application", "bla bla bla", new DateOnly(2025, 2, 2), new DateOnly(2026, 2, 2), Status.NotStarted, testWorkspace.Id);
            await userRepo.AddAsync(user);
            await workSpaceRepo.AddAsync(testWorkspace);
            await projectRepo.AddAsync(project);
            await projectRepo.AddAsync(project2);
            await context.SaveChangesAsync();
            var result = await projectRepo.GetAllProjectsInWorkspaceAsync(testWorkspace.Id);
            Assert.Equal(2, result.Count());
            Assert.Equal(testWorkspace.Id, result.First().WorkspaceId);
        }
    }
}