using System.ComponentModel.DataAnnotations;

namespace Student2WithCQRS.Domain.DTO
{
    public class CandidateDto
    {
       public int CandidateId { get; set; }
        public string? CandidateName { get; set; }


    }
}
