using MediatR;
using Student2WithCQRS.Domain.DTO;

namespace Student2WithCQRS.Application.Commands._AssessmentResult.Create
{
    public class CreateAssessmentCommand : IRequest<AssessmentResultDto>
    {
        public int CandidateId { get; set; }
        public int CategoryId { get; set; }

        public int Score { get; set; }
    }
}
