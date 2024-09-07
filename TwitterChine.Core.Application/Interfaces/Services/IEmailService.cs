using TwitterChine.Core.Application.Dtos.Email;

namespace TwitterChine.Core.Application.Interfaces.Services
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}
