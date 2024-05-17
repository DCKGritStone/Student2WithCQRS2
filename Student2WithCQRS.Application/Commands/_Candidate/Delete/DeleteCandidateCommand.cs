using MediatR;

namespace Student2WithCQRS.Application.Commands._Candidate.Delete
{
    public class DeleteCandidateCommand : IRequest<int>
    {
        public int CandidateId { get; set; }
    }
}
