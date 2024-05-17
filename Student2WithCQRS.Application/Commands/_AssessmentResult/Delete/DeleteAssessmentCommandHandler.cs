using MediatR;
using Student2WithCQRS.Domain.Interface;

namespace Student2WithCQRS.Application.Commands._AssessmentResult.Delete
{
    public class DeleteAssessmentCommandHandler : IRequestHandler<DeleteAssessmentCommand, int>
    {
        private readonly IBaseRepository baseRepository;

        public DeleteAssessmentCommandHandler(IBaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }
        public async Task<int> Handle(DeleteAssessmentCommand request, CancellationToken cancellationToken)
        {
            return await baseRepository.DeleteCategory(request.AssessmentId);
        }
    }
}
