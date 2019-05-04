using Employees.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.DTO
{
    public class EmployeePerMonth : Employee
    {
        public EmployeePerMonth(
            int employeeId,
            int document,
            string name,
            double salary,
            Contract contractType
        )
        {
            EmployeeId = employeeId;
            Document = document;
            Name = name;
            Salary = salary;
            ContractType = contractType;
        }

        public int EmployeeId { get; set; }
        public int Document { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double AnnualSalary
        {
            get
            {
                return Salary * 12;
            }
        }
        public Contract ContractType { get; set; }
    }
}
