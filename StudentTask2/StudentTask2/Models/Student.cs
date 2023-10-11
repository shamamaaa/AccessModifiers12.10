using System;
using System.Text.RegularExpressions;

namespace StudentTask2.Models
{
	public class Student
	{
        private string _name;
        private int _age;
        private int _grade;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public string FormatName(string input)
        {
            input = input.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                input = char.ToUpper(input[0]) + input.Substring(1).ToLower();
            }
            return input;
        }

        public void CheckName(string name)
        {

            Regex rg = new Regex(@"^[A-Z][a-zA-Z]*$");

            bool ValidName = false;
            while (!ValidName)
            {
                Console.Write("Ad daxil edin: ");
                string input = Console.ReadLine();
                input = FormatName(input);

                if (rg.IsMatch(input))
                {
                    Name = input;
                    ValidName = true;
                }
                else
                {
                    Console.WriteLine("Ad yanlis daxil edilib. Reqemler ve simvollardan istifade etmeden yeniden daxil edin.");
                }
            }
        }


        public void CheckAge(int age)
        {
            bool ValidAge = false;
            while (!ValidAge)
            {
                Console.Write("Yas daxil edin: ");
                int input = int.Parse(Console.ReadLine());

                if (input > 0 && input <= 150)
                {
                    Age = input;
                    ValidAge = true;
                }
                else
                {
                    Console.WriteLine("Yanlis yas daxil edildi.0 ve 150 araliqinda yas daxil edin.");
                }
            }
        }


        public void CheckGrade(int grade)
        {
            bool ValidGrade = false;
            while (!ValidGrade)
            {
                Console.Write("Derece daxil eidn: ");
                int input = int.Parse(Console.ReadLine());

                if (input >= 0 && input <= 100)
                {
                    Grade = input;
                    ValidGrade = true;
                }
                else
                {
                    Console.WriteLine("Derece duzgun daxil edilmedi. 0 ile 100 araliqinda olmalidir.");
                }
            }
        }

        public Student()
        {
            CheckName(Name);
            CheckAge(Age);
            CheckGrade(Grade);
        }
    }
}

