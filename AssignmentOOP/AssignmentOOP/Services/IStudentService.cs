using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP.Services
{
    internal interface IStudentService : IPersonService
    {
        bool add(string name, Dictionary<string, string> coursesTaken, DateTime Birthday, List<string> Address);
        void display();
        double CalculateGPA(Dictionary<string, string> courseGrades);
    }
}
