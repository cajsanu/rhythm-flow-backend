using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestUser : User
    {
        public TestUser(string firstName, string lastName, string email, string password) : base(firstName, lastName, email, password)
        {
        }
    }
}