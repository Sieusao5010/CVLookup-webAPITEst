using CVLookup_WebAPI.Models.Domain;
using CVLookup_WebAPI.Services.AccountService;
using CVLookup_WebAPI.Services.AccountUserService;
using CVLookup_WebAPI.Services.AuthService;
using CVLookup_WebAPI.Services.CandidateService;
using CVLookup_WebAPI.Services.CurriculumService;
using CVLookup_WebAPI.Services.EmployerService;
using CVLookup_WebAPI.Services.ExperienceService;
using CVLookup_WebAPI.Services.JobAddressService;
using CVLookup_WebAPI.Services.JobCareerService;
using CVLookup_WebAPI.Services.JobFieldService;
using CVLookup_WebAPI.Services.JobFormService;
using CVLookup_WebAPI.Services.JobPositionService;
using CVLookup_WebAPI.Services.RecruitmentCVService;
using CVLookup_WebAPI.Services.RecruitmentService;
using CVLookup_WebAPI.Services.RoleService;
using CVLookup_WebAPI.Services.UserRoleService;
using CVLookup_WebAPI.Services.UserService;
using CVLookup_WebAPI.Utilities;
using FirstWebApi.Models.Database;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDBContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("Connection");
    options.UseSqlServer(connectionString);
});

// Add automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Add service
builder.Services.AddScoped<IAccountUserService, AccountUserService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ICandidateService, CandidateService>();
builder.Services.AddScoped<ICurriculumViateService, CurriculumVitaeService>();
builder.Services.AddScoped<IEmployerService, EmployerService>();
builder.Services.AddScoped<IExperienceService, ExperienceService>();
builder.Services.AddScoped<IJobAddressService, JobAddressService>();
builder.Services.AddScoped<IJobCareerService, JobCareerService>();
builder.Services.AddScoped<IJobFieldService, JobFieldService>();
builder.Services.AddScoped<IJobFormService, JobFormService>();
builder.Services.AddScoped<IJobPositionService, JobPositionService>();
builder.Services.AddScoped<IRecruitmentCVService, RecruitmentCVService>();
builder.Services.AddScoped<IRecruitmentService, RecruitmentService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IUserRoleService, UserRoleService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IAuthService, AuthService>();

//Add custom data validate error
builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.InvalidModelStateResponseFactory = context =>
        {
            var messages = context.ModelState.Keys.Select(key =>
            {
                return new
                {
                    field = key,
                    message = context.ModelState[key]?.Errors.Select(error => error.ErrorMessage)
                };
			});

			var response = new ApiResponse
            {
                Success = false,
                Code = 400,
                Message = messages
            };
            return new OkObjectResult(response);
        };
    });

// Authentication with Json Web Token
builder.Services.Configure<Jwt>(builder.Configuration.GetSection("JWT"));
var secretKey = builder.Configuration["AppSettings:SecretKey"];
var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
{
    option.TokenValidationParameters = new TokenValidationParameters
    {
        //Tự ký token
        ValidateIssuer = false,
        ValidateAudience = false,

        //Ký vào token
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes),

        ClockSkew = TimeSpan.Zero
    };
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
