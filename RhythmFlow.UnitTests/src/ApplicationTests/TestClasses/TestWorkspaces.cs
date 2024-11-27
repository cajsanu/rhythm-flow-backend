using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Domain.src.Entities;

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