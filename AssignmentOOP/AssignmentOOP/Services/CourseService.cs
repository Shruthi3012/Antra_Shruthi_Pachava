using AssignmentOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP.Services
{
    internal class CourseService : ICourseService
    {
        public List<Course> _courseList = new List<Course>();
        public bool add(string courseName, List<string> studentNames)
        {
            try
            {
                Course course = new Course();
                course.CourseName = courseName;
                course.StudentNames = studentNames;
                _courseList.Add(course);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public void display()
        {
            int i = 0;
            foreach (var course in _courseList)
            {
                Console.WriteLine("Course " + i + ": Name - " + course.CourseName + 
                    ", Student Names - " + String.Join(", ", course.StudentNames));
            }
        }
    }
}
