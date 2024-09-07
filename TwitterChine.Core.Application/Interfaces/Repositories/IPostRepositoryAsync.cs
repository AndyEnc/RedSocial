using TwitterChine.Core.Domain.Entities;
using TwitterChine.Core.Application.ViewModels.PostsViewModels;

namespace TwitterChine.Core.Application.Interfaces.Repositories
{
    public interface IPostRepositoryAsync : IGenericRepositoryAsync<Posts>
    {
        Task<List<PostViewModel>> GetAllByUserId(string idUser);
    }
}
