using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmpMgmt.Models;
using Microsoft.AspNetCore.Authentication;
using EmpMgmt.ServiceInterface;
using EmpMgmt.API;

namespace EmpMgmt.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeeController : BaseController<IEmployeeService>
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService):base(employeeService)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

