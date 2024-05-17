using Student2WithCQRS.Domain.DTO;

namespace Student2WithCQRS.Domain.Interface._AssessmentResult
{
    public interface IResults
    {
        List<AssessmentResultDto> GetAllResult();
        AssessmentResultDto GetResultById(int id);

    }
}
