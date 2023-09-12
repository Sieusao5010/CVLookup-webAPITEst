using CVLookup_WebAPI.Services.AuthService;
using CVLookup_WebAPI.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace CVLookup_WebAPI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService) 
        { 
            _authService = authService;
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginVM loginVM)
        {
            try
            {
                var result = _authService.Login(loginVM.Email, loginVM.Password);
                if (result != null) 
                {
                    return Ok(new ApiResponse
                    {
                        Success = true,
                        Code = StatusCodes.Status200OK,
                        Message = "Login thành công",
                        Data = result
                    });
                }
                else
                {
                    return Ok(new ApiResponse
                    {
                        Success = false,
                        Code = StatusCodes.Status404NotFound,
                        Message = "Sai mật khẩu hoặc email",
                    });
                }
            }
            catch (Exception e)
            {
                return Ok(new ApiResponse
                {
                    Success = false,
                    Code = StatusCodes.Status500InternalServerError,
                    Message = e.Message,
                });
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> RenewToken()
        {

            return Ok();
        }
    }
    public class LoginVM
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
