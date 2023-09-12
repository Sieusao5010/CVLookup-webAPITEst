using CVLookup_WebAPI.Models.ViewModel;
using CVLookup_WebAPI.Services.JobAddressService;
using CVLookup_WebAPI.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVLookup_WebAPI.Controllers
{
	[Route("api/v1/[controller]/[action]")]
	[ApiController]
	public class JobAddressController : ControllerBase
	{
		private readonly IJobAddressService _jobAddressService;
		private readonly ILogger<JobAddressController> _logger;

		public JobAddressController(ILogger<JobAddressController> logger, IJobAddressService jobAddressService)
		{
			_jobAddressService = jobAddressService;
			_logger = logger;
		}

		[HttpGet]
		public async Task<IActionResult> getAllJobAddress()
		{
			try
			{
				var result = await _jobAddressService.JobAddressList();
				return Ok(new ApiResponse
				{
					Code = StatusCodes.Status200OK,
					Success = true,
					Data = result,
					Message = "Hoàn thành"
				});
			} catch (Exception e)
			{
				return Ok(new ApiResponse
				{
					Success = false,
					Message = e.Message,
					Code = StatusCodes.Status500InternalServerError
				});
			}
		}

		[HttpGet]
		public async Task<IActionResult> getJobAddressById([FromQuery] string id)
		{
			try
			{
				var result = await _jobAddressService.GetJobAddressById(id);
				return Ok(new ApiResponse
				{
					Success = true,
					Code = StatusCodes.Status200OK,
					Data = result,
					Message = "Hoàn thành"
				});
			}
			catch (ExceptionReturn e)
			{
				return Ok(new ApiResponse
				{
					Success = false,
					Code = e.Code,
					Message = e.Message
				});
			}
		}

		[HttpGet]
		public async Task<IActionResult> getJobAddressByAddress([FromQuery] string address)
		{
			try
			{
				var result = await _jobAddressService.GetJobAddressByAddress(address);
				return Ok(new ApiResponse
				{
					Success = true,
					Code = StatusCodes.Status200OK,
					Data = result,
					Message = "Hoàn thành"
				});
			}
			catch (ExceptionReturn e)
			{
				return Ok(new ApiResponse
				{
					Success = false,
					Code = e.Code,
					Message = e.Message
				});
			}
		}

		[HttpPost]
		public async Task<IActionResult> addJobAddress([FromBody] JobAddressVM jobAddress)
		{
			try
			{
				
				var result = await _jobAddressService.Add(jobAddress);
				return Ok(new ApiResponse
				{
					Success = true,
					Code = StatusCodes.Status200OK,
					Data = result,
					Message = "Hoàn thành"
				});
			}
			catch (ExceptionReturn e)
			{
				return Ok(new ApiResponse
				{
					Success = false,
					Code = e.Code,
					Message = e.Message
				});
			}
		}
	}
}
