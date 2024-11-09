using RhythmFlow.Domain.src.Entities;

namespace RhythmFlow.Application.src.Abstractions
{
    public interface ITicketService : IBaseService<Ticket>
    {
        // Can we somehow extract the logic for adding/removing users
        // to/from a workspace/project/ticket to a separate service?
    }
}