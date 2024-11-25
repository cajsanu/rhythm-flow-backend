using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.DTOs.Shared;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestWorkSpace(string name, Guid ownerId) : Workspace(name, ownerId)
    {
    }

    public class TestWorkSpaceReadDto : WorkspaceReadDto
    {
    }

    public class TestWorkSpaceCreateDto : WorkspaceCreateDto
    {
    }

    public class TestWorkSpaceUpdateDto : WorkspaceUpdateDto
    {
    }
}