using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Data;
using RhythmFlow.Framework.src.Repo;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.RepoTests
{
    public class UserWorkspaceRepoTests
    {
       private AppDbContext CreateInMemoryDbContextOptions()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new AppDbContext(options);
        }

       [Fact]
       public async Task AssignRoleToUserInWorkspace_ShouldAssignRoleToUserInWorkspace()
        {
            // Arrange
            using var context = CreateInMemoryDbContextOptions();
            var user1 = new TestUser("Jones", "Pence", "jones@pence.com", "fdgfsfds213!");
            var user2 = new TestUser("Monsi", "Phonsi", "jones@pence.com", "fdgfsfds213!");
            var userRepo = new BaseRepo<User>(context);
            await userRepo.AddAsync(user1);
            await userRepo.AddAsync(user2);
            var workspaceRepo = new BaseRepo<Workspace>(context);
            var userWorkspaceRepo = new UserWorkspaceRepo(context);
            var testWorkspace = new TestWorkSpace("Health", user1.Id);
            await workspaceRepo.AddAsync(testWorkspace);
            var userWorkSpace = await userWorkspaceRepo.AssignRoleToUserInWorkspace(user2.Id, testWorkspace.Id, Role.Developer);
            await context.SaveChangesAsync();
        }

       [Fact]
       public async Task GetAllUserWorkspacesByOwnedUserIdAsync_ShouldReturnAllUserWorkspacesByUserId()
        {
            using var context = CreateInMemoryDbContextOptions();
            var user1 = new TestUser("Jones", "Pence", "joneus@pence.com", "fdgfsfds213!");
            var user2 = new TestUser("Monsi", "Phonsi", "jones@pence.com", "fdgfsfds213!");
            var workspaceRepo = new BaseRepo<Workspace>(context);
            var userRepo = new BaseRepo<User>(context);
            var userWorkspaceRepo = new UserWorkspaceRepo(context);
            await userRepo.AddAsync(user1);
            await userRepo.AddAsync(user2);
            var testWorkspace = new TestWorkSpace("Health", user2.Id);
            var testWorkspace2 = new TestWorkSpace("Travel", user2.Id);
            await workspaceRepo.AddAsync(testWorkspace);
            await workspaceRepo.AddAsync(testWorkspace2);
            await userWorkspaceRepo.AssignRoleToUserInWorkspace(user2.Id, testWorkspace.Id, Role.WorkspaceOwner);
            await userWorkspaceRepo.AssignRoleToUserInWorkspace(user2.Id, testWorkspace2.Id, Role.WorkspaceOwner);
            await userWorkspaceRepo.AssignRoleToUserInWorkspace(user1.Id, testWorkspace.Id, Role.Developer);
            await context.SaveChangesAsync();
            var result = await userWorkspaceRepo.GetWorkspacesOwnedByUserAsync(user2.Id);

            Assert.Equal(2, result.Count());
            Assert.Equal(testWorkspace.OwnerId, result.First().OwnerId);
        }

       [Fact]
       public async Task GetUserWorkspaceByUserIdAndWorkspaceIdAsync_ShouldReturnUserWorkspaceByUserIdAndWorkspaceId()
        {
            using var context = CreateInMemoryDbContextOptions();
            var user1 = new TestUser("Jones", "Pence", "joneus@pence.com", "fdgfsfds213!");
            var user2 = new TestUser("Monsi", "Phonsi", "jones@pence.com", "fdgfsfds213!");
            var testWorkspace = new TestWorkSpace("Health", user2.Id);
            var workspaceRepo = new BaseRepo<Workspace>(context);
            var userRepo = new BaseRepo<User>(context);
            var userWorkspaceRepo = new UserWorkspaceRepo(context);
            await userRepo.AddAsync(user1);
            await userRepo.AddAsync(user2);
            await workspaceRepo.AddAsync(testWorkspace);
            await userWorkspaceRepo.AssignRoleToUserInWorkspace(user1.Id, testWorkspace.Id, Role.Developer);
            await context.SaveChangesAsync();
            var result = await userWorkspaceRepo.GetAllUserWorkspacesByUserIdAsync(user1.Id);

            Assert.NotNull(result);
            Assert.Single(result);
        }
    }
}