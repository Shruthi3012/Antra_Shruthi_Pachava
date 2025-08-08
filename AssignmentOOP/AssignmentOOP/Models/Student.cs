using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP.Models
{
    public class Student
    {
        
        public string Name { get; set;}

        public Dictionary<string, string> CoursesTaken { get; set; }

       // public double GPA { get; set; }
        public DateTime Birthday { get; set; }
        public List<string> Address { get; set; }


    }
}
