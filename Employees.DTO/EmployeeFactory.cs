using Employees.Data;

namespace Employees.DTO
{
    public static class EmployeeFactory
    {
        public static Employee GetEmployee(Data.Employee employee)
        {
            if(employee.ContractType == Contract.Monthly)
            {
                return new EmployeePerMonth(employee.EmployeeId, employee.Document, employee.Name, employee.Salary, employee.ContractType);
            }

            return new EmployeePerHour(employee.EmployeeId, employee.Document, employee.Name, employee.Salary, employee.ContractType);
        }
    }
}
