using TwitterChine.Core.Domain.Entities;
using TwitterChine.Core.Application.ViewModels.FriendViewModels;
using TwitterChine.Core.Application.ViewModels.PostsViewModels;

namespace TwitterChine.Core.Application.Interfaces.Services
{
    public interface IPostService:IGenericService<SavePostViewModel,PostViewModel,Posts>,IUploadFile
    {
        Task<List<PostViewModel>> GetAllByUser(string user);
        Task<List<FriendsPostViewModel>> GetAllByFriend(string idFriend);
    }
}
