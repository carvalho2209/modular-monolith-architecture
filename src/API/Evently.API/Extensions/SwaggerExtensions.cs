using Microsoft.OpenApi.Models;

namespace Evently.Api.Extensions;

internal static class SwaggerExtensions
{
    internal static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Evently API",
                Version = "v1",
                Description = "Evently API built using the modular monolith architecture.",
                Contact = new OpenApiContact() { Name = "Alexandre Carvalho", Email = "carvalho2209@hotmail.com" },
                License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/Licenses/MIT") }
            });

            options.CustomSchemaIds(t => t.FullName?.Replace("+", "."));
        });

        services.AddSwaggerGen(c =>
        {
            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = "Add your JWT token: Bearer {token}",
                Name = "Authorization",
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey
            });

            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    []
                }
            });
        });


        return services;
    }
}
