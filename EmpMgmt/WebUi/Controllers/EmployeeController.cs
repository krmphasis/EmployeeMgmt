using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmpMgmt.Models;
using Microsoft.AspNetCore.Authentication;
using EmpMgmt.ServiceInterface;
using EmpMgmt.API;
using EmpMgmt.Client;

namespace EmpMgmt.WebUi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeeController : Controller
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateEmployee(EmployeeDto employeeDto)
    {
        var employee = await _employeeService.CreateEmployee(employeeDto);
        return View(employee);
    }

    [HttpGet]
    public async Task<IActionResult> GetEmployee()
    {
        var employee = await _employeeService.GetEmployee();
        return View(employee);
    }
}

