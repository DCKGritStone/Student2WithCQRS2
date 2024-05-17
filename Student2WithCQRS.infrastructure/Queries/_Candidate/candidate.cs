using AutoMapper;
using Student2WithCQRS.Domain.DTO;
using Student2WithCQRS.Domain.Interface._Candidate;
using Student2WithCQRS.infrastructure.Data;

namespace Student2WithCQRS.infrastructure.Queries._Candidate
{
    public class candidate : ICandidate
    {
        private readonly StudentDbContext _dbContext;
        private readonly IMapper _mapper;

        public candidate(StudentDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<CandidateDto> GetAllCandidate()
        {
            return _mapper.Map<List<CandidateDto>>(_dbContext.Candidates.ToList());
        }
        public CandidateDto GetCandidateById(int id)
        {
            return _mapper.Map<CandidateDto>(_dbContext.Candidates.FirstOrDefault(S => S.CandidateId == id));
        }

        public List<CandidateForPassFailDto> GetPassFailResult()
        {
            var result = (from cand in _dbContext.Candidates
                          join res in _dbContext.Results on cand.CandidateId equals res.CandidateId
                          join cate in _dbContext.Categories on res.CategoryId equals cate.CategoryId
                          group new { res.AssessmentId, cate.CategoryName, res.Score, cate.CuttoffMarks } by new { cand.CandidateName } into g
                          select new CandidateForPassFailDto
                          {
                              CandidateName = g.Key.CandidateName,
                              ResultDetails = g.Select(item => new AssessmentResultForPassFailDto
                              {
                                  AssessmentId = item.AssessmentId,
                                  CategoryName = item.CategoryName,
                                  Status = item.Score > item.CuttoffMarks ? "Pass" : "Fail"
                              }).ToList()
                          }).ToList();
            return result;
        }
    }
}
