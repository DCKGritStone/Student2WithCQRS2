using MediatR;
using Student2WithCQRS.Domain.Interface;
using Student2WithCQRS.Domain.Entities;

namespace Student2WithCQRS.Application.Commands._AssessmentResult.Update
{
    public class UpdateAssessmentCommandHandler : IRequestHandler<UpdateAssessmentCommand, int>
    {
        private readonly IBaseRepository baseRepository;

        public UpdateAssessmentCommandHandler(IBaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }
        public async Task<int> Handle(UpdateAssessmentCommand request, CancellationToken cancellationToken)
        {
            var updateAssessment = new AssessmentResult
            {
                AssessmentId = request.AssessmentId,
                CandidateId = request.CandidateId,
                CategoryId = request.CategoryId,
                Score = request.Score
            };

            return await baseRepository.UpdateAssessment(request.AssessmentId, updateAssessment);
        }
    }
}
