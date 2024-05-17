using MediatR;

namespace Student2WithCQRS.Application.Commands._Candidate.Update
{
    public class UpdateCandidateCommand : IRequest<int>
    {
        public int CandidateId { get; set; }
        public string? CandidateName { get; set; }
    }
}
