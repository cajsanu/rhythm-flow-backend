using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Routing;

namespace RhythmFlow.Controller.src.RouteTransformer
{
    public partial class SpinCaseTransformer : IOutboundParameterTransformer
    {
        public string? TransformOutbound(object? value)
        {
            if (value is null || value.ToString() is null) return null;

            // Convert to spin-case
            return MyRegex().Replace(value.ToString(), "$1-$2").ToLower();
        }

        [GeneratedRegex("([a-z])([A-Z])")]
        private static partial Regex MyRegex();
    }
}