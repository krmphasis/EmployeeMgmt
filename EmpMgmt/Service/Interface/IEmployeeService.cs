using System;
using EmpMgmt.Client;

namespace EmpMgmt.Service.Interface
{
	public interface IEmployeeService
	{
        Task<EmployeeDto> CreateEmployee(EmployeeDto employee);
    }
}

