using Microsoft.EntityFrameworkCore;
using Student2WithCQRS.Domain.Interface;
using Student2WithCQRS.infrastructure.Data;
using Student2WithCQRS.Domain.Entities;

namespace Student2WithCQRS.infrastructure
{
    public class BaseRepository : IBaseRepository
    {
        private readonly StudentDbContext dbContext;

        public BaseRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<AssessmentResult> CreateAssessment(AssessmentResult assessmentResult)
        {
            await dbContext.Results.AddAsync(assessmentResult);
            await dbContext.SaveChangesAsync();
            return assessmentResult;
        }

        public async Task<Candidate> CreateCandidate(Candidate candidate)
        {
            await dbContext.Candidates.AddAsync(candidate);
            await dbContext.SaveChangesAsync();
            return candidate;
        }

        public async Task<AssessmentCategory> CreateCategory(AssessmentCategory assessmentCategory)
        {
            await dbContext.Categories.AddAsync(assessmentCategory);
            await dbContext.SaveChangesAsync();
            return assessmentCategory;
        }

        public async Task<int> DeleteAssessment(int id)
        { return await dbContext.Results.Where(d => d.AssessmentId == id).ExecuteDeleteAsync(); }

        public async Task<int> DeleteCandidate(int id)
        {
            return await dbContext.Candidates.Where(d => d.CandidateId == id).ExecuteDeleteAsync();
        }

        public async Task<int> DeleteCategory(int id)
        {
            return await dbContext.Categories.Where(d => d.CategoryId == id).ExecuteDeleteAsync();
        }

        public async Task<int> UpdateAssessment(int id, AssessmentResult assessmentResult)
        {
            return await dbContext.Results.Where(u => u.AssessmentId == id).ExecuteUpdateAsync(setter => setter.SetProperty(x => x.CandidateId, assessmentResult.CandidateId)
                                                                                                         .SetProperty(x => x.CategoryId, assessmentResult.CategoryId)
                                                                                                         .SetProperty(x => x.Score, assessmentResult.Score));
        }

        public async Task<int> UpdateCandidate(int id, Candidate candidate)
        {
            return await dbContext.Candidates.Where(u => u.CandidateId == id).ExecuteUpdateAsync(setter => setter.SetProperty(x => x.CandidateId, candidate.CandidateId)
                                                                                                         .SetProperty(x => x.CandidateName, candidate.CandidateName));
        }

        public async Task<int> UpdateCategory(int id, AssessmentCategory assessmentCategory)
        {
            return await dbContext.Categories.Where(u => u.CategoryId == id).ExecuteUpdateAsync(setter => setter.SetProperty(x => x.CategoryId, assessmentCategory.CategoryId)
                                                                                                         .SetProperty(x => x.CategoryName, assessmentCategory.CategoryName)
                                                                                                         .SetProperty(x => x.CuttoffMarks, assessmentCategory.CuttoffMarks));
        }
    }
}
