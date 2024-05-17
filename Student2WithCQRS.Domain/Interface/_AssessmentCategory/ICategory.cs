using Student2WithCQRS.Domain.DTO;

namespace Student2WithCQRS.Domain.Interface._AssessmentCategory
{
    public interface ICategory
    {
        List<AssessmentCategoryDto> GetAllCategory();

        AssessmentCategoryDto GetCategoryById(int id);
    }
}
