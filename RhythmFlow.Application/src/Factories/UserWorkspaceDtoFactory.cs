using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.DTOs.UserWorkspaces;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Factories
{
    public class UserWorkspaceDtoFactory : IUserWorkspaceDtoFactory
    {
        public UserWorkspaceReadDto CreateReadDto(UserWorkspace entity)
        {
            return new UserWorkspaceReadDto
            {
                UserId = entity.UserId,
                WorkspaceId = entity.WorkspaceId,
                Role = entity.Role
            };
        }

        public UserWorkspaceCreateDto CreateCreateDto(UserWorkspace entity)
        {
            return new UserWorkspaceCreateDto
            {
                UserId = entity.UserId,
                WorkspaceId = entity.WorkspaceId
            };
        }

        public UserWorkspaceUpdateDto CreateUpdateDto(UserWorkspace entity)
        {
            return new UserWorkspaceUpdateDto
            {
                UserId = entity.UserId,
                WorkspaceId = entity.WorkspaceId
            };
        }
    }
}