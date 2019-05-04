namespace Employees.Data
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int Document { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public Contract ContractType { get; set; }
    }
}
