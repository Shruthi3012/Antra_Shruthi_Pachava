using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP.Services
{
    internal interface IPersonService
    {
        int CalculateAge(string name);
        
        List<string> GetAllAddress(string name);
    }
}
