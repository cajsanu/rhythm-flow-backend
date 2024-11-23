using RhythmFlow.Application.src.DTOs.UserWorkspaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.FactoryInterfaces
{
    public interface IUserWorkspaceDtoFactory
    {
        UserWorkspaceReadDto CreateReadDto(UserWorkspace entity);
        UserWorkspaceCreateDto CreateCreateDto(UserWorkspace entity);
        UserWorkspaceUpdateDto CreateUpdateDto(UserWorkspace entity);
    }
}