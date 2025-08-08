using AssignmentOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP.Services
{
    internal class InstructorService : IInstructorService
    {

        public List<Instructor> _instructorList = new List<Instructor>(); 
        public bool add(string name, DateTime joinDate, string departmentName, DateTime birthday, List<string> address)
        {
            try
            {
                Instructor instructor = new Instructor();
                instructor.Name = name;
                instructor.JoinDate = joinDate;
                instructor.DepartmentName = departmentName;
                instructor.Birthday = birthday;
                instructor.Address = address;
                _instructorList.Add(instructor);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public int CalculateAge(string name)
        {
            foreach (var instructor in _instructorList)
            {
                if (instructor.Name.Equals(name))
                {
                    return DateTime.Now.Year - instructor.Birthday.Year;
                }
            }
            return 0;
        }

        public int CalculateExperience(DateTime joinDate)
        {
            return DateTime.Now.Year - joinDate.Year;
        }

        public void display()
        {
            int i = 1;
            foreach (var instructor in _instructorList)
            {
                Console.WriteLine("Instructor " + i);
                Console.WriteLine("Name: " + instructor.Name);
                Console.WriteLine("Join Date: " + instructor.JoinDate);
                Console.WriteLine("BirthDay: " + instructor.Birthday);
                Console.WriteLine("Department Name:" + instructor.DepartmentName);
                Console.WriteLine("Address: [" + String.Join(", ", instructor.Address) + "]");
            }
        }

        public List<string> GetAllAddress(string name)
        {
            foreach (var instructor in _instructorList)
            {
                if (instructor.Name.Equals(name))
                {
                    return instructor.Address;
                }
            }
            //not returning null due to validation  
            return new List<string>();
        }

        public decimal BonusSalary(string name)
        {
            foreach (var instructor in _instructorList)
            {
                if (instructor.Name.Equals(name))
                {
                    int exp = CalculateExperience(instructor.JoinDate);
                    return (decimal) exp * 10000 + instructor.Salary;
                }
            }
            return 0;
                       
        }
    }
}
