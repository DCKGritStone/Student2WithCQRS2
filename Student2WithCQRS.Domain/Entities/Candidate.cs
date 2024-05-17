using System.ComponentModel.DataAnnotations;

namespace Student2WithCQRS.Domain.Entities
{
    public class Candidate
    {
        [Key]public int CandidateId { get; set; }
        public string? CandidateName { get; set; }


    }
}
