using Microsoft.AspNetCore.Http;
using TwitterChine.Core.Domain.Entities;
using TwitterChine.Core.Application.ViewModels.CommentsViewModels;

namespace TwitterChine.Core.Application.ViewModels.PostsViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public string IdUser { get; set; } = null!;
        public DateTime DateOfCreated { get; set; }
        public IFormFile? File { get; set; }
        public string? Image { get; set; }
        public List<CommetViewModel>? Comments { get; set; }
    }
}
