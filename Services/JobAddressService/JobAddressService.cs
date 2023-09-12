using AutoMapper;
using CVLookup_WebAPI.Models.Domain;
using CVLookup_WebAPI.Models.ViewModel;
using CVLookup_WebAPI.Utilities;
using FirstWebApi.Models.Database;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CVLookup_WebAPI.Services.JobAddressService
{
	public class JobAddressService : IJobAddressService
	{
		private readonly AppDBContext _dbContext;
		private readonly IMapper _mapper;

		public JobAddressService(AppDBContext dbContext, IMapper mapper)
		{
			_dbContext = dbContext;
			_mapper = mapper;
		}

		public async Task<JobAddressVM> Add(JobAddressVM jobAddressVM)
		{
			try
			{
				var jobAddress = _mapper.Map<JobAddress>(jobAddressVM);
				var result = await _dbContext.JobAddress.AddAsync(jobAddress);
				if (result.State.ToString() == "Added")
				{
					int saveState = await _dbContext.SaveChangesAsync();
					if (saveState <= 0)
					{
						throw new ExceptionReturn(500, "Thất bại. Có lỗi xảy ra trong quá trình lưu dữ liệu");
					}
					return _mapper.Map<JobAddressVM>(jobAddress);
				} else
				{
					throw new ExceptionReturn(500, "Thất bại. Có lỗi xảy ra trong quá trình thêm dữ liệu");
				}
				
			} catch (ExceptionReturn e)
			{
				throw new ExceptionReturn(e.Code, e.Message);
			}
		}

		public Task<JobAddressVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public async Task<JobAddressVM> GetJobAddressById(string id)
		{
			try
			{
				if (id == null)
				{
					throw new ExceptionReturn(400, "Thất bại. Truy vấn không hợp lệ");
				}

				var result = await _dbContext.JobAddress.Where(prop => prop.Id == id).FirstOrDefaultAsync();
				if (result == null)
				{
					throw new ExceptionReturn(404, "Thất bại. Không thê tìm thấy dữ liệu");
				}
				return _mapper.Map<JobAddressVM>(result);
			}
			catch (ExceptionReturn e)
			{
				throw new ExceptionReturn(e.Code, e.Message);
			}
		}

		public async Task<JobAddressVM> GetJobAddressByAddress(string address)
		{
			try
			{
				if (address == null)
				{
					throw new ExceptionReturn(400, "Thất bại. Truy vấn không hợp lệ");
				}

				var result = await _dbContext.JobAddress.Where(prop => prop.Address == address).FirstOrDefaultAsync();
				if (result == null)
				{
					throw new ExceptionReturn(404, "Thất bại. Không thê tìm thấy dữ liệu");
				}
				return _mapper.Map<JobAddressVM>(result);
			}
			catch (ExceptionReturn e)
			{
				throw new ExceptionReturn(e.Code, e.Message);
			}
		}

		public async Task<List<JobAddressVM>> JobAddressList()
		{
			try
			{
				var jobAddressList = await _dbContext.JobAddress.ToListAsync();
				return _mapper.Map<List<JobAddressVM>>(jobAddressList);
			}
			catch (ExceptionReturn e)
			{
				throw new ExceptionReturn(500, e.Message);
			}
		}

		public Task<JobAddressVM> Update(string Id, JobAddressVM newJobAddress)
		{
			throw new NotImplementedException();
		}
	}
}
