namespace Student2WithCQRS.Domain.DTO
{
    public class AssessmentCategoryDto
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int CuttoffMarks { get; set; }
    }
}
