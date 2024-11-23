using RhythmFlow.Application.src.DTOs.Projects;
using RhythmFlow.Application.src.DTOs.Tickets;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.ApplicationTests.TestClasses
{
    public class TestProject(string name, string description, DateOnly startDate, DateOnly endDate, Status status, Guid workspaceId) : Project(name, description, startDate, endDate, status, workspaceId)
    {
    }

    public class TestProjectReadDto : ProjectReadDto
    {
    }

    public class TestProjectCreateDto : ProjectCreateDto
    {
    }

    public class TestProjectUpdateDto : ProjectUpdateDto
    {
    }
}