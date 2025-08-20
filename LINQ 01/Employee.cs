using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_01
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(string Name , string Department,double Salary )
        {
            this.Name = Name;
            this.Department = Department;
            this.Salary = Salary;
        }

    }
}
