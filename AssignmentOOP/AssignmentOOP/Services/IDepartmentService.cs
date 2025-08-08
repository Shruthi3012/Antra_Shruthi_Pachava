using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP.Services
{
    internal interface IDepartmentService
    {
        bool add(string name, decimal budget, List<string> courseList);
        void displayDepartment();
    }
}
