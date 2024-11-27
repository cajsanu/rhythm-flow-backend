using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestUser(string firstName, string lastName, string email, string password) : User(firstName, lastName, email, password)
    {
    }

    public class TestUserReadDto : UserReadDto
    {
    }

    public class TestUserCreateDto : UserCreateDto
    {
    }

    public class TestUserUpdateDto : UserUpdateDto
    {
    }
}