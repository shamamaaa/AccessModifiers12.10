
using EmployeeTask.Models;

Employee employee = new Employee("Samama", true, 500);
Employee employee1 = new Employee("Zulfiyya", true, 600);
Employee employee2 = new Employee("Seid", false, 150);
Employee employee3 = new Employee("Sabuhi", false, 200);

Assistant assistant = new Assistant();

assistant.Getfeedback(employee);
assistant.Getfeedback(employee1);
assistant.Getfeedback(employee2);
assistant.Getfeedback(employee3);

Console.WriteLine($"{employee.Name} maas: {employee.Salary}");
Console.WriteLine($"{employee1.Name} maas: {employee1.Salary}");
Console.WriteLine($"{employee2.Name} maas: {employee2.Salary}");
Console.WriteLine($"{employee3.Name} maas: {employee3.Salary}");
