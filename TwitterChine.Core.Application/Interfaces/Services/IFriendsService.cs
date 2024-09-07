using TwitterChine.Core.Domain.Entities;
using TwitterChine.Core.Application.ViewModels.FriendViewModels;

namespace TwitterChine.Core.Application.Interfaces.Services
{
    public interface IFriendsService:IGenericService<AddFriendViewModel,FriendViewModel,Friends>
    {
        Task<List<FriendViewModel>> GetAllByUser(string user);
        Task<bool> IsFriendAdd(string idUser, string idFriend);
    }
}
