using Microsoft.AspNetCore.Http;

namespace TwitterChine.Core.Application.Interfaces.Services
{
    public interface IUploadFile
    {
        string UplpadFile(IFormFile file,string userName);
    }
}
