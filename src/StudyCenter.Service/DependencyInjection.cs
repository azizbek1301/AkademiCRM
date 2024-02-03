using MediatR;
using Microsoft.Extensions.DependencyInjection;
using StudyCenter.Service.Abstraction.File;
using StudyCenter.Service.Service.Files;
using System.Reflection;

namespace StudyCenter.Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient<IFileService, FileService>();
            return services;
        }
    }
}
