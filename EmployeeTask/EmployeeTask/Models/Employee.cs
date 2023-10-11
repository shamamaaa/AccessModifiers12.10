using System;
namespace EmployeeTask.Models
{
	public class Employee
	{
        public string Name { get; set; }

        public bool IsSuccessfull { get; set; }

        public decimal Salary { get; set; }

        public Employee(string name, bool issuccessfull, decimal salary)
        {
            Name = name;
            IsSuccessfull = issuccessfull;
            Salary = salary;
        }
    }
}

