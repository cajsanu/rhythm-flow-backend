using Moq;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Services;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.ApplicationTests.ServiceTests
{
    public class UserServiceTests
    {
        private readonly Mock<IUserRepo> _mockUserRepo;
        private readonly Mock<IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>> _mockDtoFactory;
        private readonly UserService _service;
        private readonly PasswordService _passwordService;

        public UserServiceTests()
        {
            _passwordService = new PasswordService();
            _mockUserRepo = new Mock<IUserRepo>();
            _mockDtoFactory = new Mock<IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>>();
            _service = new UserService(_mockUserRepo.Object, _mockDtoFactory.Object, _passwordService);
        }

        [Fact]
        public async Task AddAsync_ShouldAddUser_WhenValidInput()
        {
            // Arrange
            var userCreateDto = new TestUserCreateDto
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Password = "password123"
            };
            var newUser = new TestUser(userCreateDto.FirstName, userCreateDto.LastName, userCreateDto.Email, _passwordService.HashPassword(userCreateDto.Password));
            var dto = new TestUserReadDto { Id = newUser.Id };

            _mockUserRepo.Setup(repo => repo.GetUserByEmailAsync(It.IsAny<Email>())).ReturnsAsync((User)null);
            _mockUserRepo.Setup(repo => repo.AddAsync(It.IsAny<User>())).ReturnsAsync(newUser);
            _mockDtoFactory.Setup(factory => factory.CreateReadDto(newUser)).Returns(dto);

            // Act
            var result = await _service.AddAsync(userCreateDto);

            // Assert
            Assert.Equal(newUser.Id, result.Id);
        }

        [Fact]
        public async Task AddAsync_ShouldThrowException_WhenUserAlreadyExists()
        {
            // Arrange
            var userCreateDto = new TestUserCreateDto
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Password = "password123"
            };
            var existingUser = new TestUser(userCreateDto.FirstName, userCreateDto.LastName, userCreateDto.Email, _passwordService.HashPassword(userCreateDto.Password));

            _mockUserRepo.Setup(repo => repo.GetUserByEmailAsync(It.IsAny<Email>())).ReturnsAsync(existingUser);

            // Act & Assert
            await Assert.ThrowsAsync<InvalidOperationException>(() => _service.AddAsync(userCreateDto));
        }

        [Fact]
        public async Task UpdateAsync_ShouldUpdateUserEmail_WhenValidInput()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var userUpdateDto = new TestUserUpdateDto
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "new.email@example.com", // Updated email
                PasswordHash = "newpassword123"
            };
            var existingUser = new TestUser("John", "Doe", "old.email@example.com", _passwordService.HashPassword("oldpassword123")) { Id = userId };
            var updatedUser = new TestUser(userUpdateDto.FirstName, userUpdateDto.LastName, userUpdateDto.Email, _passwordService.HashPassword(userUpdateDto.PasswordHash)) { Id = userId };
            var dto = new TestUserReadDto { Id = updatedUser.Id, Email = updatedUser.Email.Value };

            _mockUserRepo.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(existingUser);
            _mockUserRepo.Setup(repo => repo.UpdateAsync(It.IsAny<User>())).ReturnsAsync(updatedUser);
            _mockDtoFactory.Setup(factory => factory.CreateReadDto(updatedUser)).Returns(dto);

            // Act
            var result = await _service.UpdateAsync(userId, userUpdateDto);

            // Assert
            Assert.Equal(updatedUser.Id, result.Id);
            Assert.Equal("new.email@example.com", result.Email); // Check that the email is updated
        }

        [Fact]
        public async Task GetUserByEmailAsync_ShouldReturnUser_WhenValidInput()
        {
            // Arrange
            TestUser userTry = new TestUser("jon", "don", "avid@mail.com", "32f!");
            var email = new Email("avid@mail.com");
            var TestUserReadDto = new TestUserReadDto { Id = userTry.Id };
            _mockUserRepo.Setup(repo => repo.GetUserByEmailAsync(email)).ReturnsAsync(userTry);
            _mockDtoFactory.Setup(factory => factory.CreateReadDto(userTry)).Returns(TestUserReadDto);

            // Act
            var result = await _service.GetUserByEmailAsync(email);

            // Assert
            Assert.Equal(userTry.Id, result.Id);
        }

        [Fact]
        public async Task GetUserByEmailAsync_ShouldThrowException_WhenUserNotFound()
        {
            // Arrange
            var email = new Email("john.doe@example.com");

            _mockUserRepo.Setup(repo => repo.GetUserByEmailAsync(email)).ReturnsAsync((User)null);

            // Act & Assert
            await Assert.ThrowsAsync<KeyNotFoundException>(() => _service.GetUserByEmailAsync(email));
        }
    }
}
