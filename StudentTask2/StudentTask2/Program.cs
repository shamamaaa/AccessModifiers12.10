using StudentTask2.Models;

namespace StudentTask2;
class Program
{
    static void Main(string[] args)
    {

        Student student = new Student();
        Console.WriteLine();
        Console.WriteLine("Telebe:");
        Console.WriteLine("Ad: " + student.Name);
        Console.WriteLine("Yas: " + student.Age);
        Console.WriteLine("Derece: " + student.Grade);

    }
}


