using RhythmFlow.Domain.src.Entities;
namespace RhythmFlow.Application.src.DTOs.Shared
{
    // more about covariance here: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-generic-modifier
    public interface IBaseCreateDto<out T>
        where T : BaseEntity

    {
        public T ToEntity();
    }
}
