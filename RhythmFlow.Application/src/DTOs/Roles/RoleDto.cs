using RhythmFlow.Domain.src.ValueObjects;

namespace RhythmFlow.Application.src.DTOs.Roles
{
    public class RoleDto
    {
        public Role Role { get; set; }

        public Role ToEntity()
        {
            return Role;
        }
    }
}
