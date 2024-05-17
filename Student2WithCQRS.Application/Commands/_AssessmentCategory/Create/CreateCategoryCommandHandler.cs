using AutoMapper;
using MediatR;
using Student2WithCQRS.Domain.Interface;
using Student2WithCQRS.Domain.DTO;
using Student2WithCQRS.Domain.Entities;

namespace Student2WithCQRS.Application.Commands._AssessmentCategory.Create
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, AssessmentCategoryDto>
    {
        private readonly IBaseRepository baseRepository;
        private readonly IMapper mapper;

        public CreateCategoryCommandHandler(IBaseRepository baseRepository, IMapper mapper)
        {
            this.baseRepository = baseRepository;
            this.mapper = mapper;
        }
        public async Task<AssessmentCategoryDto> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var createCategory = new AssessmentCategory
            {
                CategoryName = request.CategoryName,
                CuttoffMarks = request.CuttoffMarks
            };

            var result = await baseRepository.CreateCategory(createCategory);

            return mapper.Map<AssessmentCategoryDto>(result);
        }
    }
}
