using Microsoft.EntityFrameworkCore;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Data;
using RhythmFlow.Framework.src.Repo;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.RepoTests
{
    public class BaseRepoTests
    {
        private AppDbContext CreateInMemoryDbContextOptions()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new AppDbContext(options);
        }

        [Fact]
        public async Task AddAsync_ShouldAddEntity()
        {
            using var context = CreateInMemoryDbContextOptions();
            var repo = new UserRepo(context);
            var newUser = new TestUser("Jones", "Pence", "jones@pence.com", "fdgfsfds213!");

            // Act
            var result = await repo.AddAsync(newUser);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(newUser.Id, result.Id);
            Assert.Equal(1, await context.Users.CountAsync());
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnEntityById()
        {
            // Arrange
            using var context = CreateInMemoryDbContextOptions();
            var repo = new UserRepo(context);
            var userId = Guid.NewGuid();
            var newUser = new TestUser("Jones", "Pence", "jones@pence.com", "fdgfsfds213!") { Id = userId };
            context.Users.Add(newUser);
            await context.SaveChangesAsync();

            // Act
            var result = await repo.GetByIdAsync(userId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(userId, result!.Id);
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnAllEntities()
        {
            // Arrange
            using var context = CreateInMemoryDbContextOptions();
            var repo = new UserRepo(context);
            context.Users.AddRange(new List<User>
            {
                new TestUser("Jones", "Pence", "jones@pence.com", "fdgfsfds213!"),
                new TestUser("Monsi", "Phonsi", "jones@pence.com", "fdgfsfds213!"),
            });
            await context.SaveChangesAsync();

            // Act
            var result = await repo.GetAllAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, (await repo.GetAllAsync()).Count());
        }

        [Fact]
        public async Task DeleteAsync_ShouldRemoveEntity()
        {
            // Arrange
            using var context = CreateInMemoryDbContextOptions();
            var repo = new UserRepo(context);
            var userId = Guid.NewGuid();
            context.Users.Add(new TestUser("Jones", "Pence", "jones@pence.com", "fdgfsfds213!") { Id = userId });
            await context.SaveChangesAsync();

            // Act
            await repo.DeleteAsync(userId);

            // Assert
            Assert.Null(await context.Users.FindAsync(userId));
        }

        [Fact]
        public async Task UpdateAsync_ShouldUpdateEntity()
        {
            // Arrange
            using var context = CreateInMemoryDbContextOptions();
            var repo = new UserRepo(context);
            var userId = Guid.NewGuid();
            var user = new TestUser("Jones", "Pence", "jones@pence.com", "fdgfsfds213!") { Id = userId };
            context.Users.Add(user);
            await context.SaveChangesAsync();

            // Act
            user.Email = new Email("jones2@pence.com");
            var result = await repo.UpdateAsync(user);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("jones2@pence.com", result!.Email.Value);
        }
    }
}