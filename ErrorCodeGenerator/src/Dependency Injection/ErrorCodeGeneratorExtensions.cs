using ErrorCodeGeneratorCore.src.Interfaces;
using ErrorCodeGeneratorCore.src.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ErrorCodeGeneratorCore.src.Dependency_Injection
{
    public static class ErrorCodeGeneratorExtensions
    {
        public static IServiceCollection AddErrorCodeGenerator(this IServiceCollection services)
        {
            services.AddScoped<IErrorCodeGenerator, ErrorCodeGenerator>();
            return services;
        }
    }
}
