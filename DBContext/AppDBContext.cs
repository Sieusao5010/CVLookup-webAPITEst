using CVLookup_WebAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FirstWebApi.Models.Database
{
	public class AppDBContext : DbContext
	{
		public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
		{

		}	

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<Account>()
			//    .HasIndex(prop => prop.Email)
			//    .IsUnique();
			modelBuilder.Entity<Account>()
				.HasIndex(prop => prop.Email)
				.IsUnique();

			modelBuilder.Entity<User>()
				.HasIndex(prop => prop.Email)
				.IsUnique();

			modelBuilder.Entity<UserRole>()
				.HasKey(prop => new { prop.RoleId, prop.UserId });

			modelBuilder.Entity<AccountUser>()
				.HasKey(prop => new { prop.AccountID, prop.UserId });

			modelBuilder.Entity<RecruitmentCV>()
				.HasKey(prop => new { prop.RecruitmentId, prop.CurriculumVitaeId });

			modelBuilder.Entity<RefreshToken>()
				.HasNoKey();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			base.OnConfiguring(builder);
		}


		#region DBSet
		public DbSet<Account> Account { get; set; }
		public DbSet<Role> Role { get; set; }
		public DbSet<Candidate> Candidate { get; set; }
		public DbSet<JobAddress> JobAddress { get; set; }
		public DbSet<JobCareer> JobCareer { get; set; }
		public DbSet<JobPosition> JobPosition { get; set; }
		public DbSet<JobField> JobField { get; set; }
		public DbSet<JobForm> JobForm { get; set; }
		public DbSet<Recruitment> Recruitment { get; set; }
		public DbSet<Experience> Experience { get; set; }
		public DbSet<Employer> Employer { get; set; }
		public DbSet<CurriculumVitae> CurriculumVitae { get; set; }
		public DbSet<AccountUser> AccountUser { get; set; }
		public DbSet<UserRole> UserRole { get; set; }
		public DbSet<RecruitmentCV> RecruitmentCV { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<RefreshToken> RefreshToken { get; set; }
		//public DbSet<RecruitmentCV> RecruitmentCV { get; set; }
		//public DbSet<EmployerAccount> EmployerAccount { get; set; }
		//public DbSet<CandidateAccount> CandidateAccount { get; set; }
		#endregion
	}

}
