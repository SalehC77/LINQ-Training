using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_01
{
    internal class StudentDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
        public bool Gender { get; set; }
        //public int  Index { get; set; }
        public string Marks { get; set; }
        public StudentDto(string name ,int age,int level,bool gender,string mark)
        {
            this.Name = name;
            this.Age = age;
            this.Level = level;
            this.Gender = gender;
            this.Marks = mark;
            //this.Index = index;
        }
    }
}
