using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Student2WithCQRS.Domain.Interface;
using Student2WithCQRS.Domain.Interface._AssessmentCategory;
using Student2WithCQRS.Domain.Interface._AssessmentResult;
using Student2WithCQRS.Domain.Interface._Candidate;
using Student2WithCQRS.infrastructure;
using Student2WithCQRS.infrastructure.Data;
using Student2WithCQRS.infrastructure.Queries._AssessmentCategory;
using Student2WithCQRS.infrastructure.Queries._AssessmentResult;
using Student2WithCQRS.infrastructure.Queries._Candidate;

namespace Student2WithCQRS.Application
{
    public static class ConfigureService
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StudentDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("StudentCQRSConnection") ??
                throw new InvalidOperationException("Connection string 'StudentCQRSConnection' not found ")));
            services.AddScoped<IResults, Result>();
            services.AddScoped<ICandidate, candidate>();
            services.AddScoped<ICategory, Category>();
            services.AddScoped<IBaseRepository, BaseRepository>();
            return services;

        }
    }
}
