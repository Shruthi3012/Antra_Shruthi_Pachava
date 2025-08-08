using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP.Models
{
    public class Instructor
    {
       public string Name { get; set; }
        public DateTime JoinDate { get;set; }

        public string DepartmentName { get; set; }
        
        public DateTime Birthday { get; set; }

        public List<string> Address {  get; set; }

        public decimal Salary {  get; set; }
    }
}
