using EmpMgmt.Client;

namespace EmpMgmt.ServiceInterface;
public interface IEmployeeService
{
    Task<EmployeeDto> CreateEmployee(EmployeeDto employee);
    Task<EmployeeDto> GetEmployee();
}

