using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP.Models
{
    public class Department
    {
    public string DepartmentName { get; set; }
        public decimal Budget { get; set; }  

        public List<string> CoursesList { get; set; }
    }
}
