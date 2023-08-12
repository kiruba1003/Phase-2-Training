using Microsoft.EntityFrameworkCore;
using System;
using EFCF.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF.Context
{
    internal class EmployeeManagement:DbContext
    {
        public DbSet<Dept> Depts { get; set; }

        public DbSet<Emp> Emps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = ASHWIN_PC\\SQLEXPRESS; initial catalog = EmployeeManagement; integrated security=SSPI; TrustServerCertificate=True;");
        }

    }
}
