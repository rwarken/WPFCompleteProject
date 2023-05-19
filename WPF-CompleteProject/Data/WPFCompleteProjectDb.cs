using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using WPF_CompleteProject.Data.DataModel;

namespace WPF_CompleteProject.Data
{
    public class WPFCompleteProjectDb : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer("Server=WinSvr19a;Database=warkenDB;Trusted_Connection=true;User Id=warken;Password=Hrk40mcd");
			//Data Source = WinSvr19a; User ID = warken; Password = ********; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
			//optionsBuilder.UseSqlServer("Server=WinSvr19a;" +
			//	"User ID=warken;" +
			//	"Password=Hrk40mcd;" +
			//	"Connect Timeout=30;" +
			//	"Encrypt=False;" +
			//	"Trust Server Certificate=False;" +
			//	"Application Intent=ReadWrite;" +
			//	"Multi Subnet Failover = False");
			optionsBuilder.UseSqlServer("Server=WinSvr19a;" +
				"Database = warkenDB;" +
				"User ID=warken;" +
				"Password=Hrk40mcd;" +
				"Connect Timeout = 30;" +
				"Encrypt=False;" +
				"Trust Server Certificate=False;");
		}

		public DbSet<Employee> Employees { get; set; }
	}
}
