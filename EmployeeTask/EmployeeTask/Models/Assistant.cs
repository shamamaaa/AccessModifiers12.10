using System;
namespace EmployeeTask.Models
{
	public class Assistant:Manager
	{

        public void Getfeedback(Employee employee)
        {
            if (employee.IsSuccessfull)
            {
                GetPromation(ref employee);
            }
            else
            {
                Console.WriteLine($"{employee.Name} maasinda deyisiklik yoxdur");
            }

        }

    }
}

