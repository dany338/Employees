using Employees.DTO;
using System.Collections.Generic;

namespace Employees.Service
{
    public interface IEmployeeService
    {
        Employee GetEmployee(int document);
        List<Employee> GetEmployees();
    }
}
