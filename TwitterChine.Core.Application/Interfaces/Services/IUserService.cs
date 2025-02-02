﻿using TwitterChine.Core.Domain.Entities;
using TwitterChine.Core.Application.Dtos.Account;
using TwitterChine.Core.Application.ViewModels.UsersViewModels;

namespace TwitterChine.Core.Application.Interfaces.Services
{
    public interface IUserService:IUploadFile
    {
        Task<AuthenticationReponse> LoginAsync(LoginViewModel request);
        Task SignOutAsync();
        Task<RegisterResponse> RegisterAsync(RegisterUserViewModel model, string origin);
        Task<string> ConfirmEmailAsync(string userdId, string token);
        Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordViewModel model, string origin);
        Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordViewModel model);
        Task<RegisterUserViewModel> GetByUsername(string username);
    }
}
