using MediatR;
using Student2WithCQRS.Domain.Entities;
using Student2WithCQRS.Domain.Interface;

namespace Student2WithCQRS.Application.Commands._AssessmentCategory.Update
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, int>
    {
        private readonly IBaseRepository baseRepository;

        public UpdateCategoryCommandHandler(IBaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }
        public async Task<int> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var updateCategory = new AssessmentCategory
            {
                CategoryId = request.CategoryId,
                CategoryName = request.CategoryName,
                CuttoffMarks = request.CuttoffMarks
            };

            return await baseRepository.UpdateCategory(request.CategoryId, updateCategory);
        }
    }
}
