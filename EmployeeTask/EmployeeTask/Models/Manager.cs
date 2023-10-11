using System;
namespace EmployeeTask.Models
{
	public class Manager
	{
        protected Employee GetPromation(ref Employee employee)
        {
            employee.Salary = employee.Salary + 100;
            return employee;
        }
    }
}

