using Microsoft.OpenApi.Validations;
using Moq;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Framework.src.Services;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.ApplicationTests
{
    public class UserServiceTests
    {
        private readonly Mock<IUserRepo> _mockUserRepo;
        private readonly Mock<IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>> _mockDtoFactory;
        private readonly UserService _service;
        private readonly PasswordService passwordService;

        public UserServiceTests()
        {
            passwordService = new PasswordService();
            _mockUserRepo = new Mock<IUserRepo>();
            _mockDtoFactory = new Mock<IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>>();
            _service = new UserService(_mockUserRepo.Object, _mockDtoFactory.Object, passwordService);
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
            //Assert
            Assert.Equal(userTry.Id, result.Id);
        }
    }
}
