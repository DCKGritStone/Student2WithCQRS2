using MediatR;
using Student2WithCQRS.Domain.DTO;

namespace Student2WithCQRS.Application.Commands._Candidate.Create
{
    public class CreateCandidateCommand : IRequest<CandidateDto>
    {
        public string? CandidateName { get; set; }
    }
}
