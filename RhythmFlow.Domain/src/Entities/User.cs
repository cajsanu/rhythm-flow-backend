using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.Domain.src.Helpers;

namespace RhythmFlow.Domain.src.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Email Email { get; set; }
        public string PasswordHash { get; set; } 

        // Make collection of projects that the user is assigned to
        public ICollection<Project> Projects { get; set; } = [];

        // Make collection of tickets that the user is assigned to
        public ICollection<Ticket> Tickets { get; set; } = [];
    

        public User(string firstName, string lastName, string email, string password) : base() // Call the base constructor to generate a unique ID
        {
            // firstName and lastName validation in the constructor and email validation in the setter. 
            // This is mainly because the users name will probably not change wile the email might. 
            if (DomainHelpers.IsNotValidStringValue(firstName) || DomainHelpers.IsNotValidStringValue(lastName)) throw new InvalidDataException("First name and last name must not be null or empty");

            FirstName = firstName;
            LastName = lastName;
            Email = new Email(email); // Trigger validation.
            PasswordHash = password;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            return Id == ((User)obj).Id || Email == ((User)obj).Email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Email);
        }

        public override string ToString()
        {
            return $"Id: {Id} name: {FirstName} {LastName}, email: ({Email.Value})";
        }
    }
}