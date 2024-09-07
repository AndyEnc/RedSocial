using TwitterChine.Core.Domain.Entities;
using TwitterChine.Core.Application.ViewModels.CommentsViewModels;

namespace TwitterChine.Core.Application.Interfaces.Services
{
    public interface ICommentService:IGenericService<SaveCommentViewModel,CommetViewModel,Comments>
    {
        Task<List<CommetViewModel>> GetAllByPostId(int idPost);
    }
}
