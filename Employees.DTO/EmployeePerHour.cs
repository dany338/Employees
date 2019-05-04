using Employees.Data;

namespace Employees.DTO
{
    public class EmployeePerHour : Employee
    {
        public EmployeePerHour(
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
                return 120 * Salary * 12;
            }
        }
        public Contract ContractType { get; set; }
    }
}
