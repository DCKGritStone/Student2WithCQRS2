using AutoMapper;
using Student2WithCQRS.Domain.Interface._AssessmentResult;
using Student2WithCQRS.infrastructure.Data;
using Student2WithCQRS.Domain.DTO;

namespace Student2WithCQRS.infrastructure.Queries._AssessmentResult
{
    public class Result : IResults
    {
        private readonly StudentDbContext dbContext;
        private readonly IMapper mapper;

        public Result(StudentDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public List<AssessmentResultDto> GetAllResult()
        {
            return mapper.Map<List<AssessmentResultDto>>(dbContext.Results.ToList());
        }
        public AssessmentResultDto GetResultById(int id)
        {
            return mapper.Map<AssessmentResultDto>(dbContext.Results.FirstOrDefault(S => S.AssessmentId == id));
        }


    }
}
