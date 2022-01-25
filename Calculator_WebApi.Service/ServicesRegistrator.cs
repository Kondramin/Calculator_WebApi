using Calculator_WebApi.Services.Interfaces;
using Calculator_WebApi.Services.Realizations;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator_WebApi.Services
{
    public static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IMathOperationService, MathOperationService>()
            ;
    }
}
