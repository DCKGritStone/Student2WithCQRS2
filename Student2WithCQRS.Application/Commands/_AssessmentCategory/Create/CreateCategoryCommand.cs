using MediatR;
using Student2WithCQRS.Domain.DTO;

namespace Student2WithCQRS.Application.Commands._AssessmentCategory.Create
{
    public class CreateCategoryCommand : IRequest<AssessmentCategoryDto>
    {
        public string? CategoryName { get; set; }
        public int CuttoffMarks { get; set; }
    }
}