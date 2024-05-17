using MediatR;

namespace Student2WithCQRS.Application.Commands._AssessmentCategory.Delete
{
    public class DeleteCategoryCommand : IRequest<int>
    {
        public int CategoryId { get; set; }
    }
}
