using Authorizatsiya.Api.Models;

namespace Authorizatsiya.Api.Interface
{
    public interface IAuthService
    {
        ValueTask<string> GenerateToken(Login login);
    }
}
