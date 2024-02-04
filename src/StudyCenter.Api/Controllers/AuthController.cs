using Authorizatsiya.Api.Interface;
using Authorizatsiya.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace StudyCenter.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async ValueTask<IActionResult> LoginAsync(Login login)
        {
            string token = await _authService.GenerateToken(login);

            return Ok(token);
        }
    }
}
