using MediatR;

namespace Student2WithCQRS.Application.Commands._AssessmentResult.Update
{
    public class UpdateAssessmentCommand : IRequest<int>
    {
        public int AssessmentId { get; set; }

        public int CandidateId { get; set; }
        public int CategoryId { get; set; }

        public int Score { get; set; }

    }

}
