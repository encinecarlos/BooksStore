using System.Reflection;

namespace BookStore.Api.Extensions
{
    public static class MediatorExtension
    {
        public static void AddMediatorExtension(this IServiceCollection services) 
        {
            services.AddMediatR(opt =>
            {
                opt.RegisterServicesFromAssemblies(Assembly.Load("BookStore.Application"));
            });        
        }
    }
}
