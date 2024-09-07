using TwitterChine.Core.Domain.Entities;

namespace TwitterChine.Core.Application.Interfaces.Repositories
{
    public interface IFriendRepositotyAsync:IGenericRepositoryAsync<Friends>
    {
        Task<List<Friends>> GetAllByUser(string user);
        Task<bool>IsFriendAdd(string idUser, string idFriend);
    }
}
