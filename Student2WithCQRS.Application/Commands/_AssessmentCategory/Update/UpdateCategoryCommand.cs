using MediatR;

namespace Student2WithCQRS.Application.Commands._AssessmentCategory.Update
{
    public class UpdateCategoryCommand : IRequest<int>
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int CuttoffMarks { get; set; }
    }
}
