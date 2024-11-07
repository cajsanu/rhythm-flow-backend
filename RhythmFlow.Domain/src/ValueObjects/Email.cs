using System.Text.RegularExpressions;

namespace RhythmFlow.Domain.src.ValueObjects
{
    public class Email
    {
        private string _value = string.Empty; // Initialise email to empty string before a valid value is provided
        public string Value
        {
            get => _value;
            set
            {
                {
                    if (Regex.IsMatch(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")) _value = value;
                    else throw new InvalidDataException("Invalid email address");
                }
            }
        }

        public Email(string value)
        {
            Value = value;
        }
    }
}