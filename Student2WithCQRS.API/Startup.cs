using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Extensions.Configuration;
using Student2WithCQRS.Application.Comman.Mapping;

namespace Student2WithCQRS.API
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationServices();
            services.AddInfrastructureServices(configuration);
           /* services.Configure<ConfigSettings>(Configuration);
            services.AddPermissionPolicies(); // Authorization policies
            services.AddMvcCore()
                .AddApiExplorer()
                .AddDataAnnotations()
                .AddFormatterMappings();
            services.AddHttpContextAccessor();
            services.AddSwagger(Configuration);
            services.AddCors(options =>
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                options.AddPolicy(CorsPolicy,
                builder => builder
                    .SetIsOriginAllowed((host) => true)
                    .WithOrigins(new string[] { Configuration.Get<ConfigSettings>().CorsOrigin })
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            });
            services.ConfigureAuthService(Configuration);
            services.AddAutoMapper(typeof(AutoMapping));
            services.AddCustomDbContext(Configuration);
            services.InitialiseDatabase(3);
            var insightKey = Configuration.Get<ConfigSettings>()?.ApplicationInsightsKey;
            if (!string.IsNullOrEmpty(insightKey))
                services.AddApplicationInsightsTelemetry(insightKey);
            services.AddEventBus(Configuration);
            services.AddHttpClient<IApiClient, ApiClient>();
            services.AddCache(_hostingEnvironment, Configuration);
            services.AddHealthChecks(Configuration);
            services.AddVersioning();
            services.AddControllers(o =>
            {
                o.Filters.Add(typeof(HeaderValidationFilter));
            });
            services.AddScoped<HeaderValidationFilter>();*/
        }
    }
}
