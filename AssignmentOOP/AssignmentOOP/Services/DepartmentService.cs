using AssignmentOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP.Services
{
    internal class DepartmentService : IDepartmentService
    {
        List<Department> _departmentsList = new List<Department>();
        public bool add(string name, decimal budget, List<string> courseList)
        {
            try
            {
                Department department = new Department();
                department.Budget= budget;
                department.DepartmentName= name;
                department.CoursesList= courseList;
                _departmentsList.Add(department);

                return true;
            }
            catch 
            {
              return false;
            }
        }

        public void displayDepartment()
        {
            int i = 0;
            foreach (var department in _departmentsList)
            {
                Console.WriteLine("Department " + i + ": Name - " + department.DepartmentName + ", Budget - " +
                    department.Budget + ", Course List - " + String.Join(", ", department.CoursesList));
            }
        }
    }
}
