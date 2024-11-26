using Moq;
using RhythmFlow.Application.DTOs.Workspaces;
using RhythmFlow.Application.src.DTOs.Users;
using RhythmFlow.Application.src.DTOs.Workspaces;
using RhythmFlow.Application.src.FactoryInterfaces;
using RhythmFlow.Application.src.Services;
using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.RepoInterfaces;
using RhythmFlow.UnitTests.src.ApplicationTests.TestClasses;

namespace RhythmFlow.UnitTests.src.ApplicationTests.ServiceTests
{
    public class WorkspaceServiceTests
    {
        private readonly Mock<IUserRepo> _mockUserRepo;
        private readonly Mock<IDtoFactory<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>> _mockWorkspaceDtoFactory;
        private readonly Mock<IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>> _mockUserDtoFactory;
        private readonly AssignmentService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto> _assignmentService;
        private readonly Mock<IWorkspaceRepo> _mockWorkspaceRepo;
        private readonly Mock<IUserWorkspaceRepo> _mockUserWorkspaceRepo;
        private readonly WorkspaceService _service;

        public WorkspaceServiceTests()
        {
            _mockUserRepo = new Mock<IUserRepo>();
            _mockWorkspaceDtoFactory = new Mock<IDtoFactory<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>>();
            _mockUserDtoFactory = new Mock<IDtoFactory<User, UserReadDto, UserCreateDto, UserUpdateDto>>();
            _mockWorkspaceRepo = new Mock<IWorkspaceRepo>();
            _mockUserWorkspaceRepo = new Mock<IUserWorkspaceRepo>();
            _assignmentService = new AssignmentService<Workspace, WorkspaceReadDto, WorkspaceCreateDto, WorkspaceUpdateDto>(_mockUserRepo.Object, _mockWorkspaceRepo.Object, _mockWorkspaceDtoFactory.Object);

            _service = new WorkspaceService(_assignmentService, _mockWorkspaceDtoFactory.Object, _mockUserDtoFactory.Object, _mockUserWorkspaceRepo.Object, _mockWorkspaceRepo.Object);
        }

        [Fact]
        public async Task GetWorkSapcesJoinedByUser_ShouldReturnWorkSpaces_WhenValidInput()
        {
            var userId = Guid.NewGuid();
            var userId2 = Guid.NewGuid();
            TestWorkSpace workspace1 = new TestWorkSpace("Travel workspace", userId2);
            var workSapcesJoinedByUser = new List<Workspace> { workspace1 };
            _mockUserWorkspaceRepo.Setup(repo => repo.GetAllUserWorkspacesByUserIdAsync(userId)).ReturnsAsync(workSapcesJoinedByUser);
            var result = await _service.GetAllWorkspaceJoinedByUserAsync(userId);

            // Assert
            Assert.Single(result);
        }

        [Fact]
        public async Task GetWorkSapcesOwnedByUser_ShouldReturnWorkSpaces_WhenValidInput()
        {
            var userId = Guid.NewGuid();
            var userId2 = Guid.NewGuid();
            TestWorkSpace workspace1 = new TestWorkSpace("Travel workspace", userId2);
            var workSapcesOwnedByUser = new List<Workspace> { workspace1 };
            _mockUserWorkspaceRepo.Setup(repo => repo.GetWorkspacesOwnedByUserAsync(userId)).ReturnsAsync(workSapcesOwnedByUser);
            var result = await _service.GetAllWorkspaceOwnedByUserAsync(userId);

            // Assert
            Assert.Single(result);
        }
    }
}
