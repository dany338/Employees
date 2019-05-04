using Employees.Data;

namespace Employees.DTO
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int Document { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double AnnualSalary { get; set; }
        public Contract ContractType { get; set; }
    }
}
