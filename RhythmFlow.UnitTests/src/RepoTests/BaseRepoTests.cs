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
        private DbContextOptions<AppDbContext> CreateInMemoryDbContextOptions()
        {
           return new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) // Create a new in-memory database for each test
                .Options;
        }

        [Fact]
        public async Task AddAsync_ShouldAddEntity()
        {
             var options = CreateInMemoryDbContextOptions();
             using var context = new AppDbContext(options);
             var repo = new BaseRepo<User>(context);
             var newUser = new TestUser("Jones", "Pence", "jones@pence.com", "fdgfsfds213!");

            // Act
             var result = await repo.AddAsync(newUser);

            // Assert
             Assert.NotNull(result);
             Assert.Equal(newUser.Id, result.Id);
             Assert.Equal(1, await context.Users.CountAsync());
        }

        public async Task GetByIdAsync_ShouldReturnEntityById()
        {
            // Arrange
            var options = CreateInMemoryDbContextOptions();
            using var context = new AppDbContext(options);
            var repo = new BaseRepo<User>(context);
            var userId = Guid.NewGuid();
            var newUser = new TestUser("Jones", "Pence", "jones@pence.com", "fdgfsfds213!"){ Id = userId };
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
            var options = CreateInMemoryDbContextOptions();
            using var context = new AppDbContext(options);
            var repo = new BaseRepo<User>(context);
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
            var options = CreateInMemoryDbContextOptions();
            using var context = new AppDbContext(options);
            var repo = new BaseRepo<User>(context);
            var userId = Guid.NewGuid();
            context.Users.Add(new TestUser("Jones", "Pence", "jones@pence.com", "fdgfsfds213!"){ Id = userId });
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
            var options = CreateInMemoryDbContextOptions();
            using var context = new AppDbContext(options);
            var repo = new BaseRepo<User>(context);
            var userId = Guid.NewGuid();
            var user = new TestUser("Jones", "Pence", "jones@pence.com", "fdgfsfds213!"){ Id = userId };
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