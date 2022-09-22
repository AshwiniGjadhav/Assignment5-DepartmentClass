using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_DepartmentClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Department[] department =
            {
           new Department {Id=14,Name="HR",Location="PUNE" },
            new Department {Id=17,Name="devlopment",Location="mumbai" },
             new Department{Id=19,Name="Banking",Location="pune" },
             new Department{Id=13,Name="Technical",Location="delhi" },
             new Department{Id=23,Name="HR",Location="Banglore" },
            };

            Console.WriteLine("\n");
            foreach (Department d in department)
            {
                Console.WriteLine(d);
            }
        }
    }
}
