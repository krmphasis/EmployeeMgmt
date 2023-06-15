using System;
using AutoMapper;
using EmpMgmt.Client;
using EmpMgmt.Models;
using EmpMgmt.Repository.Interface;
using EmpMgmt.ServiceInterface;

namespace EmpMgmt.Service.Implementation
{
	public class EmployeeService : IEmployeeService
	{
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
		public EmployeeService(IMapper mapper, IEmployeeRepository employeeRepository)
		{
            _mapper = mapper;
            _employeeRepository = employeeRepository;
		}

        public Task<EmployeeDto> CreateEmployee(EmployeeDto employee)
        {
            var employee = _mapper.Map<Employee>(employee);
            var createdEmployee = await _employeeRepository.CreateEmployee(employee);
            var createdEmployeeDto = _mapper.Map<EmployeeDto>(createdEmployee);
            return createdEmployeeDto;
        }
    }
}

