using System;
using EmpMgmt.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmpMgmt.Context.Config
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {

        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.ToTable("Employee");
        }
    }
}

