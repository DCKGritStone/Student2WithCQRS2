using MediatR;
using Student2WithCQRS.Domain.Interface;

namespace Student2WithCQRS.Application.Commands._AssessmentCategory.Delete
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, int>
    {
        private readonly IBaseRepository baseRepository;

        public DeleteCategoryCommandHandler(IBaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }
        public async Task<int> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            return await baseRepository.DeleteCategory(request.CategoryId);
        }
    }
}
