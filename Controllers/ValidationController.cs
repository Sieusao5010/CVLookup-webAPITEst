using CVLookup_WebAPI.Services.AccountService;
using CVLookup_WebAPI.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace CVLookup_WebAPI.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IUserService _userService;

        public ValidationController(IAccountService accountService, IUserService userService)
        {
            _accountService = accountService;
            _userService = userService;
        }

        [HttpGet()]
        [HttpPost()]
        public async Task<IActionResult> AccountEmailIsUsed(string email)
        {
            try
            {
                var result = await _accountService.GetAccountByEmail(email);
                if (result == null)
                {
                    return new JsonResult(true);
                }
                else
                {
                    return new JsonResult("Tài khoản với email [" + email + "] đã được đăng kí bởi 1 người khác");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet()]
        [HttpPost()]
        public async Task<IActionResult> UserEmailIsUsed(string email)
        {
            try
            {
                var result = await _userService.GetAccountByEmail(email);
                if (result == null)
                {
                    return new JsonResult(true);
                }
                else
                {
                    return new JsonResult("Tài khoản với email [" + email + "] đã được đăng kí bởi 1 người khác");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
