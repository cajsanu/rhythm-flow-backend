namespace RhythmFlow.Domain.src.Helpers
{
    public static class DomainHelpers
    {
        public static bool IsNotValidStringValue(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}
