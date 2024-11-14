using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.UnitTests.src.DomainTests
{
    public class WorkspaceTests
    {
        [Fact]
        public void CreateWorkspace_WithValidData_ShouldCreateWorkspace()
        {
            // Arrange
            var name = "Workspace Name";
            var ownerId = Guid.NewGuid();

            // Act
            var workspace = new Workspace(name, ownerId);

            // Assert
            Assert.Equal(name, workspace.Name);
            Assert.Equal(ownerId, workspace.OwnerId);
        }

        [Fact]
        public void CreateWorkspace_WithInvalidName_ShouldThrowException()
        {
            // Arrange
            var name = "";
            var ownerId = Guid.NewGuid();

            // Act & Assert
            Assert.Throws<InvalidDataException>(() => new Workspace(name, ownerId));
        }
    }
}