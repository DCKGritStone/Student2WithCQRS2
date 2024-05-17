using AutoMapper;
using Student2WithCQRS.Domain.Interface._AssessmentCategory;
using Student2WithCQRS.infrastructure.Data;
using Student2WithCQRS.Domain.DTO;

namespace Student2WithCQRS.infrastructure.Queries._AssessmentCategory
{
    public class Category : ICategory
    {

        private readonly StudentDbContext dbContext;
        private readonly IMapper mapper;

        public Category(StudentDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public List<AssessmentCategoryDto> GetAllCategory()
        {
            return mapper.Map<List<AssessmentCategoryDto>>(dbContext.Categories.ToList());
        }

        public AssessmentCategoryDto GetCategoryById(int id)
        {
            return mapper.Map<AssessmentCategoryDto>(dbContext.Categories.FirstOrDefault(S => S.CategoryId == id));
        }
    }
}
