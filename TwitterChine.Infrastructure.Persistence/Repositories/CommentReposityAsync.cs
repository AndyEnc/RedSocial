using TwitterChine.Core.Domain.Entities;
using TwitterChine.Infrastructure.Persistence.Contexts;
using TwitterChine.Core.Application.Interfaces.Repositories;

namespace TwitterChine.Infrastructure.Persistence.Repositories
{
    public class CommentReposityAsync : GenericRepositoryAsync<Comments>, ICommentRepository
    {
        private readonly ApplicationContext _dbContext;
        public CommentReposityAsync(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Comments> GetAllByPostId(int idPost)
        {
            return _dbContext.Comments.Where(x=> x.IdPost == idPost).ToList(); 
        }
    }
}
