using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employees.DTO;

namespace Employees.Models
{
    public class EmployeeModel
    {
        public EmployeeModel()
        {
            Employees = new List<Employee>();
        }

        public int Document { get; set; }
        public List<Employee> Employees { get; set; }
    }
}