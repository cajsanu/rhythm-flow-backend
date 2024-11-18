using RhythmFlow.Domain.src.Entities;
using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.UnitTests.src.DomainTests
{
    public class ProjectTests
    {
        [Fact]
        public void CreateProject_WithValidData_ShouldCreateProject()
        {
            // Arrange
            var name = "Project Name";
            var description = "Project Description";
            var startDate = DateTime.Now;
            var endDate = DateTime.Now.AddMonths(1);
            var status = Status.InProgress;
            var workspaceId = Guid.NewGuid();

            // Act
            var project = new Project(name, description, startDate, endDate, status, workspaceId);

            // Assert
            Assert.Equal(name, project.Name);
            Assert.Equal(description, project.Description);
            Assert.Equal(startDate, project.StartDate);
            Assert.Equal(endDate, project.EndDate);
            Assert.Equal(status, project.Status);
            Assert.Equal(workspaceId, project.WorkspaceId);
        }

        [Fact]
        public void CreateProject_WithInvalidName_ShouldThrowException()
        {
            // Arrange
            var name = "";
            var description = "Project Description";
            var startDate = DateTime.Now;
            var endDate = DateTime.Now.AddMonths(1);
            var status = Status.InProgress;
            var workspaceId = Guid.NewGuid();

            // Act & Assert
            Assert.Throws<InvalidDataException>(() => new Project(name, description, startDate, endDate, status, workspaceId));
        }

        [Fact]
        public void CreateProject_WithInvalidDescription_ShouldThrowException()
        {
            // Arrange
            var name = "Project Name";
            var description = "";
            var startDate = DateTime.Now;
            var endDate = DateTime.Now.AddMonths(1);
            var status = Status.InProgress;
            var workspaceId = Guid.NewGuid();

            // Act & Assert
            Assert.Throws<InvalidDataException>(() => new Project(name, description, startDate, endDate, status, workspaceId));
        }
    }
}
