using System;
using EmpMgmt.Models.Data;
using EmpMgmt.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmpMgmt.Repository.Implementation
{
	public class EmployeeRepository : IEmployeeRepository
	{
        internal AppContext context;
        internal DbSet<Employee> dbSet;
		public EmployeeRepository(AppContext appContext)
		{

		}

        public Task<Employee> CreateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}

