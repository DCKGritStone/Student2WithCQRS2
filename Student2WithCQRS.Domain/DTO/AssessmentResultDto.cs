namespace Student2WithCQRS.Domain.DTO
{
    public class AssessmentResultDto
    {
        public int AssessmentId { get; set; }

        public int CandidateId { get; set; }
        public int CategoryId { get; set; }

        public int Score { get; set; }
    }
}
