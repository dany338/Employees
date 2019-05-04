using System.Collections.Generic;

namespace Employees.Data
{
    public static class DataBase
    {
        public static List<Employee> Employees { get {
                return new List<Employee> {
                    new Employee{EmployeeId = 1, Document = 1, ContractType = Contract.Monthly, Name = "Pepito 1", Salary = 3000000},
                    new Employee{EmployeeId = 2, Document = 2, ContractType = Contract.PerHour, Name = "Pepito 2", Salary = 1300000},
                    new Employee{EmployeeId = 3, Document = 3, ContractType = Contract.Monthly, Name = "Pepito 3", Salary = 2000000},
                    new Employee{EmployeeId = 4, Document = 4, ContractType = Contract.PerHour, Name = "Pepito 4", Salary = 4000000}
                };
        } }
    }
}
