

using Microsoft.EntityFrameworkCore;
using Moq;
using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Data;
using RhythmFlow.Framework.src.Repo;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.RepoTests
{
    public class UserWorkspaceRepoTests
    {
        private DbContextOptions<AppDbContext> CreateInMemoryDbContextOptions()
        {
            return new DbContextOptionsBuilder<AppDbContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString()) // Create a new in-memory database for each test
                 .Options;
        }

        [Fact]
        public async Task AssignRoleToUserInWorkspace_ShouldAssignRoleToUserInWorkspace()
        {
            // Arrange
            var options = CreateInMemoryDbContextOptions();
            using var context = new AppDbContext(options);
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
            Assert.Equal(Role.Developer.ToString(), userWorkSpace.Role.ToString());
        }

        /**
        [Fact]
        public async Task GetAllUserWorkspacesByUserIdAsync_ShouldReturnAllUserWorkspacesByUserId()
        {
            var options = CreateInMemoryDbContextOptions();
            using var context = new AppDbContext(options);
            var user1 = new TestUser("Jones", "Pence", "jones@pence.com", "fdgfsfds213!");
            var user2 = new TestUser("Monsi", "Phonsi", "jones@pence.com", "fdgfsfds213!");
            var testWorkspace = new TestWorkSpace("Health", user2.Id);
            var testWorkspace2 = new TestWorkSpace("Travel", user2.Id);
            var workspaceRepo = new BaseRepo<Workspace>(context);
            var userRepo = new BaseRepo<User>(context);
            var userWorkspaceRepo = new UserWorkspaceRepo(context);
            await userRepo.AddAsync(user1);
            await userRepo.AddAsync(user2);
            await workspaceRepo.AddAsync(testWorkspace);
            await workspaceRepo.AddAsync(testWorkspace2);
            await userWorkspaceRepo.AssignRoleToUserInWorkspace(user2.Id, testWorkspace.Id, Role.WorkspaceOwner);
            await userWorkspaceRepo.AssignRoleToUserInWorkspace(user2.Id, testWorkspace2.Id, Role.WorkspaceOwner);
           

            await context.SaveChangesAsync();
            var result = await userWorkspaceRepo.GetWorkspacesOwnedByUserAsync(user1.Id);

           Assert.Equal(2, result.Count());


        } **/

    }
}