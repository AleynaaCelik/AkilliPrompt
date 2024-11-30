using AkilliPrompt.Domain.Identity;
using AkilliPrompt.Persistence.EntityFramework.Contexts;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace AkilliPrompt.WebApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebApi(this IServiceCollection services, IConfiguration configuration)
        {
           

            return services;
        }
    }
}
