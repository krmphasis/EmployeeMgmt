using System;
using EmpMgmt.Context.Config;
using EmpMgmt.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace EmpMgmt.Context
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        #region Properties

        public DbSet<Employee> Employees { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }

        public void CreateDatabase()
        {
            Database.EnsureCreated();
            Database.EnsureDeleted();
        }
    }
}

