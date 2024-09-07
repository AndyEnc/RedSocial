using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TwitterChine.Infrastructure.Persistence.Contexts;
using TwitterChine.Infrastructure.Persistence.Repositories;
using TwitterChine.Core.Application.Interfaces.Repositories;

namespace TwitterChine.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region Contexts
            if (configuration.GetValue<bool>("UseInMemoryDataBase"))
            {
                services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName))
                );
            }
            #endregion

            #region Repositories
            services.AddTransient(typeof(IGenericRepositoryAsync<>),typeof(GenericRepositoryAsync<>));
            services.AddTransient<IPostRepositoryAsync,PostRepositoryAsync>();
            services.AddTransient<IFriendRepositotyAsync,FriendsRepositoryAsync>();
            services.AddTransient<ICommentRepository,CommentReposityAsync>();
            #endregion

        }

    }
}