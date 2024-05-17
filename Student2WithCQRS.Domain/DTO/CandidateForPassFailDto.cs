namespace Student2WithCQRS.Domain.DTO
{
    public class CandidateForPassFailDto
    {
        public string? CandidateName { get; set; }

        public List<AssessmentResultForPassFailDto>? ResultDetails { get; set; }
    }
}
