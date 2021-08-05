using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class NMBER_SystemMainDbContext : DbContext
	{
		public NMBER_SystemMainDbContext(DbContextOptions<NMBER_SystemMainDbContext> options)
				: base(options)
		{


		}

		public DbSet<AuthUserInformation> AuthUserInformation { get; set; }
		public DbSet<UserInformation> UserInformation { get; set; }
		public DbSet<NMBERAlert> NMBERAlert { get; set; }
		public DbSet<UserLoginInformation> UserLoginInformation { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

		{
			// optionsBuilder.UseSqlServer(Configuration.GetConnectionString("EmployeeDbContext"));
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AuthUserInformation>()
				.HasKey(x => x.Id);

			modelBuilder.Entity<UserInformation>()
				.HasKey(x => x.UserGuid);

			modelBuilder.Entity<NMBERAlert>()
				.HasKey(x => x.NMBERAlertGuid);

			modelBuilder.Entity<UserLoginInformation>()
				.HasKey(x => x.Id);


		}
	}
}


