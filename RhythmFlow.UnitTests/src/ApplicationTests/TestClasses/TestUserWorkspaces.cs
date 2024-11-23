using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.DTOs.UserWorkspaces;
using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestUserWorkspace(Guid userId, Guid workspaceId, Role role) : UserWorkspace(userId, workspaceId, role)
    {
    }
    public class TestUserWorkspaceReadDto : UserWorkspaceReadDto
    {
    }
    public class TestUserWorkSpaceCreateDto : UserWorkspaceCreateDto
    {
    }
    public class TestUserWorkSpaceUpdateDto : UserWorkspaceUpdateDto
    {
    }
}