using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_DepartmentClass
{
 public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"  Department Details: {Id} {Name} {Location}";
        }
    }
}
