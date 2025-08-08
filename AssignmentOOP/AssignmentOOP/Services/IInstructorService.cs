using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP.Services
{
    internal interface IInstructorService : IPersonService
    {
        bool add(string name, DateTime joinDate, string departmentName, DateTime birthday, List<string> address);
        void display();
        int CalculateExperience(DateTime joinDate);
        decimal BonusSalary(string name);
    }
}
