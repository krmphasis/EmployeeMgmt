using System;
namespace EmpMgmt.Models.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; } = default!;
        public string? Department { get; set; }
        public string? Email { get; set; }
        public string? PhotoPath { get; set; }
    }
}

