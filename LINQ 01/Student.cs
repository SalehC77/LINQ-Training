using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_01
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }
        public int Level { get; set; }
        public bool Gender { get; set; }

        public IEnumerable<string> Marks { get; set; }
        public static void PrintAll(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Id = {student.Id}, Name = {student.Name} , Age = {student.Age} , Gender = {student.Gender} ,level = {student.Level}");
            }  
        }
        public static void Print(Student student)
        {
            if (student is null) Console.WriteLine("null");
            else Console.WriteLine($"Id = {student.Id}, Name = {student.Name} , Age = {student.Age}, Gender = {student.Gender} ,level = {student.Level}");
        }
    }
}
