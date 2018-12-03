using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace SimpleBlog.API.Infrastructure
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services) 
        {
            // Register Swagger Gen service
            services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc("v1", new Info { Title = "SimpleBlog API", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new ApiKeyScheme 
                {
                    Description = "Authorisation header using the Bearer scheme. Example: \"ApiAuth: Bearer {key}\"",
                    Name = "ApiAuth",
                    In = "header",
                    Type = "apiKey"
                });
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app) 
        {
            // Enable Swagger
            app.UseSwagger();
            // Enable middleware to serve Swagger UI
            app.UseSwaggerUI(c =>
            { 
                c.SwaggerEndpoint("swagger/v1/swagger.json", "SimpleBlog.API v1");
                c.RoutePrefix = string.Empty;
            });

            return app;
        }
    }
}