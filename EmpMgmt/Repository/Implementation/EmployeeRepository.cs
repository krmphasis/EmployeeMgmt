using System;
using EmpMgmt.Models.Data;
using EmpMgmt.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmpMgmt.Repository.Implementation
{
	public class EmployeeRepository : IEmployeeRepository
	{
        //internal AppContext context;
        internal DbSet<Employee> dbSet;
		// public EmployeeRepository(AppContext appContext)
		// {

		// }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            await Task.Delay(1);
            return new Employee{
                Id = 1,
                EmployeeName = "Test",
                Email = "test@gmail.com"
            };
        }
    }
}

