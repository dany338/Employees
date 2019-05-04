using Employees.Data;
using Employees.DTO;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Employees.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly string _UrlSchema = ConfigurationManager.AppSettings["ApiUrl"];
        const string UrlSchemaPath = "/api/Employee";

        public DTO.Employee GetEmployee(int document)
        {
            var employee = DataBase.Employees.SingleOrDefault(r => r.Document == document);
            if(employee != null)
            {
                return EmployeeFactory.GetEmployee(employee);
            }

            return null;
        }

        public List<DTO.Employee> GetEmployees()
        {
            List<DTO.Employee> employees = new List<DTO.Employee>();
            foreach (var employee in DataBase.Employees)
            {
                employees.Add(EmployeeFactory.GetEmployee(employee));
            }

            return employees;
        }
    }
}
