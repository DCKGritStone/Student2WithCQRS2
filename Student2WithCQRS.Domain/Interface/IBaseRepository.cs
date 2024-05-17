using Student2WithCQRS.Domain.Entities;

namespace Student2WithCQRS.Domain.Interface
{
    public interface IBaseRepository
    {
        Task<Candidate> CreateCandidate(Candidate candidate);
        Task<int> UpdateCandidate(int id, Candidate candidate);
        Task<int> DeleteCandidate(int id);


        Task<AssessmentResult> CreateAssessment(AssessmentResult assessmentResult);
        Task<int> UpdateAssessment(int id, AssessmentResult assessmentResult);
        Task<int> DeleteAssessment(int id);
        Task<AssessmentCategory> CreateCategory(AssessmentCategory assessmentCategory);
        Task<int> UpdateCategory(int id, AssessmentCategory assessmentCategory);
        Task<int> DeleteCategory(int id);

    }
}
