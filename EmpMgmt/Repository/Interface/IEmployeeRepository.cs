using System;
using EmpMgmt.Models.Data;

namespace EmpMgmt.Repository.Interface
{
	public interface IEmployeeRepository
	{
        Task<Employee> CreateEmployee(Employee employee);
    }
}

