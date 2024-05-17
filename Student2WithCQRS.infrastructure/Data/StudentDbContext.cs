using Microsoft.EntityFrameworkCore;
using Student2WithCQRS.Domain.Entities;

namespace Student2WithCQRS.infrastructure.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AssessmentResult> Results { get; set; }
        public DbSet<AssessmentCategory> Categories { get; set; }

        public DbSet<Candidate> Candidates { get; set; }
    }
}
