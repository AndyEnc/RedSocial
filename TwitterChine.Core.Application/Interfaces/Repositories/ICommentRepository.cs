using TwitterChine.Core.Domain.Entities;

namespace TwitterChine.Core.Application.Interfaces.Repositories
{
    public interface ICommentRepository:IGenericRepositoryAsync<Comments>
    {
        List<Comments> GetAllByPostId(int idPost);
    }
}
