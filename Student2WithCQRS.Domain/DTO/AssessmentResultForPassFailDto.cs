namespace Student2WithCQRS.Domain.DTO
{
    public class AssessmentResultForPassFailDto
    {
        public int AssessmentId { get; set; }
        public string? CategoryName { get; set; }

        public string? Status { get; set; }
    }
}
