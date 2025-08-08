using AssignmentOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP.Services
{
    internal class StudentService : IStudentService
    {

        public List<Student> _studentsList = new List<Student>();

        public bool add(string name, Dictionary<string, string> coursesTaken, DateTime Birthday, List<string> Address)
        {
            try
            {
                Student student = new Student();
                student.Name = name;
                student.Birthday = Birthday;
                student.Address = Address;
                student.CoursesTaken = coursesTaken;
                _studentsList.Add(student);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void display()
        {
            int i = 1;
            foreach (var student in _studentsList)
            {
                Console.WriteLine("Student " + i);
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("BirthDay: " + student.Birthday);
                Console.WriteLine("Courses: [" + String.Join(", ", student.CoursesTaken) + "]");
                Console.WriteLine("Address: [" + String.Join(", ", student.Address) + "]");
            }
        }

        public double CalculateGPA(Dictionary<string, string> courseGrades)
        {
            double result = 0;
            int sum = 0;
            foreach (string course in courseGrades.Keys)
            {
                if (courseGrades[course] == "A")
                    sum = sum + 4;
                else if (courseGrades[course] == "B")
                    sum = sum + 3;
                else if (courseGrades[course] == "C")
                    sum = sum + 2;

            }
            result = (double)sum / (double)courseGrades.Count;

            return Math.Round(result, 2);
            
        }

        public int CalculateAge(string name)
        {
            foreach (var student in _studentsList)
            {
              if(student.Name.Equals(name))
                {
                    return DateTime.Now.Year - student.Birthday.Year;
                }
            }
            return 0;
        }

        

        public List<string> GetAllAddress(string name)
        {
            foreach (var student in _studentsList)
            {
                if (student.Name.Equals(name))
                {
                    return student.Address;
                }
            }
            //not returning null due to validation  
            return new List<string>();
        }

    }
}
