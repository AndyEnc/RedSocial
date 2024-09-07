using AutoMapper;
using TwitterChine.Core.Domain.Entities;
using TwitterChine.Core.Application.Dtos.Account;
using TwitterChine.Core.Application.ViewModels.CommentsViewModels;
using TwitterChine.Core.Application.ViewModels.FriendViewModels;
using TwitterChine.Core.Application.ViewModels.PostsViewModels;
using TwitterChine.Core.Application.ViewModels.UsersViewModels;

namespace TwitterChine.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region Users
            CreateMap<AuthenticationRequest, LoginViewModel>()
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<RegisterRequest, RegisterUserViewModel>()
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.File, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ForgotPasswordRequest, ForgotPasswordViewModel>()
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ResetPasswordRequest, ResetPasswordViewModel>()
               .ForMember(x => x.HasError, opt => opt.Ignore())
               .ForMember(x => x.Error, opt => opt.Ignore())
               .ReverseMap();
            #endregion

            #region Posts

            CreateMap<Posts, SavePostViewModel>()
                .ForMember(x => x.File, opt => opt.Ignore())
                
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Comments, opt => opt.Ignore());

            CreateMap<Posts, PostViewModel>()
                .ForMember(x => x.File, opt => opt.Ignore())
                .ForMember(x => x.Comments, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Comments, opt => opt.Ignore());

            #endregion

            #region Friends
            CreateMap<Friends, AddFriendViewModel>()
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());
            
            CreateMap<Friends, FriendViewModel>()
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            #endregion

            #region Comments
            CreateMap<Comments, SaveCommentViewModel>()
               .ReverseMap()
               .ForMember(x => x.Post, opt => opt.Ignore())
               .ForMember(x => x.Created, opt => opt.Ignore())
               .ForMember(x => x.CreatedBy, opt => opt.Ignore())
               .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());
            
            CreateMap<Comments, CommetViewModel>()
               .ReverseMap()
               .ForMember(x => x.Post, opt => opt.Ignore())
               .ForMember(x => x.Created, opt => opt.Ignore())
               .ForMember(x => x.CreatedBy, opt => opt.Ignore())
               .ForMember(x => x.LastModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());


            #endregion
        }

    }
}
