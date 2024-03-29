﻿using System;
using AutoMapper;
using EmpMgmt.Client;
using EmpMgmt.Models;
using EmpMgmt.Models.Data;
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

        public async Task<EmployeeDto> CreateEmployee(EmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            var createdEmployee = await _employeeRepository.CreateEmployee(employee);
            var createdEmployeeDto = _mapper.Map<EmployeeDto>(createdEmployee);
            return createdEmployeeDto;
        }

        public async Task<EmployeeDto> GetEmployee()
        {
           var employee = await _employeeRepository.GetEmployee();

           return _mapper.Map<EmployeeDto>(employee);
        }
    }
}

