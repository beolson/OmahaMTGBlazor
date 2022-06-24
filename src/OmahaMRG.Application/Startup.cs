
using Microsoft.Extensions.DependencyInjection;
using OmahaMRG.Application.Posts;

namespace OmahaMRG.Application
{
    public static class Startup
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddTransient<IPostManager, PostManager>();

            return services;
        }
    }
}