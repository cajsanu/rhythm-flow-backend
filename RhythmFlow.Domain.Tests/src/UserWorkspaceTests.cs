using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Domain.Tests.src
{
    public class UserWorkspaceTests
    {
        [Fact]
        public void CreateUserWorkspace_WithValidData_ShouldCreateUserWorkspace()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var workspaceId = Guid.NewGuid();
            var role = Role.ProjectManager;

            // Act
            var userWorkspace = new UserWorkspace(userId, workspaceId, role);

            // Assert
            Assert.Equal(userId, userWorkspace.UserId);
            Assert.Equal(workspaceId, userWorkspace.WorkspaceId);
            Assert.Equal(role, userWorkspace.Role);
        }
    }
}