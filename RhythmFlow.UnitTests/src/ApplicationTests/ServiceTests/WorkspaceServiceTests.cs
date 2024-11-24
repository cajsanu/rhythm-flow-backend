using Moq;
using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.Domain.src.ValueObjects;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.ApplicationTests
{
    public class WorkspaceServiceTests
    {
        private readonly Mock<IUserRepo> _mockUserRepo;
        private readonly Mock<IDtoFactory<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>> _mockDtoFactory;
        private readonly AssignmentService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto> _assignmentService;
        private readonly Mock<IWorkspaceRepo> _mockWorkspaceRepo;
        private readonly Mock<IUserWorkspaceRepo> _mockUserWorkspaceRepo;
        private readonly WorkspaceService _service;

        public WorkspaceServiceTests()
        {
            _mockUserRepo = new Mock<IUserRepo>();
            _mockDtoFactory = new Mock<IDtoFactory<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>>();
            _mockWorkspaceRepo = new Mock<IWorkspaceRepo>();
            _mockUserWorkspaceRepo = new Mock<IUserWorkspaceRepo>();
            _assignmentService = new AssignmentService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>(_mockUserRepo.Object, _mockWorkspaceRepo.Object, _mockDtoFactory.Object);

            _service = new WorkspaceService(_assignmentService, _mockDtoFactory.Object, _mockUserWorkspaceRepo.Object, _mockWorkspaceRepo.Object);
        }

        [Fact]
        public async Task GetWorkSapcesJoinedByUser_ShouldReturnWorkSpaces_WhenValidInput()
        {
            var userId = Guid.NewGuid();
            var userId2 = Guid.NewGuid();
            TestWorkSpace workspace1 = new TestWorkSpace("Travel workspace", userId2);           
             var workSapcesJoinedByUser = new List<Workspace> { workspace1 };
            _mockUserWorkspaceRepo.Setup(repo => repo.GetAllUserWorkspacesByUserIdAsync(userId)).ReturnsAsync(workSapcesJoinedByUser);
            var result = await _service.GetAllWorkspaceJoinedByUser(userId);
            // Assert
            Assert.Equal(1, result.Count());
        }

        [Fact]
        public async Task GetWorkSapcesOwnedByUser_ShouldReturnWorkSpaces_WhenValidInput()
        {
            var userId = Guid.NewGuid();
            var userId2 = Guid.NewGuid();
            TestWorkSpace workspace1 = new TestWorkSpace("Travel workspace", userId2);           
             var workSapcesOwnedByUser = new List<Workspace> { workspace1 };
            _mockUserWorkspaceRepo.Setup(repo => repo.GetWorkspacesOwnedByUserAsync(userId)).ReturnsAsync(workSapcesOwnedByUser);
            var result = await _service.GetAllWorkspaceOwnedByUser(userId);
            // Assert
            Assert.Equal(1, result.Count());
        }


    }
}
