using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Domain.src.RepoInterfaces
{
    public interface IProjectRepo : IBaseRepo<Project>
    {
        // For project we could include tickets when getting by id from the repo
        // so we can get all the tickets in a project and not need a separate method for it

        // Add methods for assigning a user to a project and removing a user from a project
        // AssignUserToProject()
        // RemoveUserFromProject()
    }
}