using System.ComponentModel.DataAnnotations;

namespace Student2WithCQRS.Domain.Entities
{
    public class AssessmentCategory
    {
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int CuttoffMarks { get; set; }
    }
}
