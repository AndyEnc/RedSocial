using Microsoft.Extensions.DependencyInjection;
using TwitterChine.Core.Application.Interfaces.Services;
using TwitterChine.Core.Application.Services;
using System.Reflection;

namespace TwitterChine.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            #region Services
            services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            services.AddTransient<IUserService, UserServices>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IFriendsService, FriendsService>();
            services.AddTransient<ICommentService, CommentService>();
            #endregion
        }
    }
}