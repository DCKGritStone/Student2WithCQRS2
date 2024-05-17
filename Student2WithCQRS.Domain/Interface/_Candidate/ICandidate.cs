using Student2WithCQRS.Domain.DTO;

namespace Student2WithCQRS.Domain.Interface._Candidate
{
    public interface ICandidate
    {
        List<CandidateDto> GetAllCandidate();

        CandidateDto GetCandidateById(int id);
        List<CandidateForPassFailDto> GetPassFailResult();
    }
}
