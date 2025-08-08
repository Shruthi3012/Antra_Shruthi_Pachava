using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP.Services
{
    internal interface ICourseService
    {
        bool add(string courseName, List<string> studentNames);
        void display();
    }
}
