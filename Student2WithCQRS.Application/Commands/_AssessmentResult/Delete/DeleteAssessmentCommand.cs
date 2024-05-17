using MediatR;

namespace Student2WithCQRS.Application.Commands._AssessmentResult.Delete
{
    public class DeleteAssessmentCommand : IRequest<int>
    {
        public int AssessmentId { get; set; }
    }
}
