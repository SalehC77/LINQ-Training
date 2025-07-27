// See https://aka.ms/new-console-template for more information
using LINQ_01;

Console.WriteLine("Hello, World!");

List<Student> students = new() {
    new() {Id = 1 , Name = "Saleh" ,Age = 20 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com"},
    new() {Id = 2 , Name = "Saleh" ,Age = 24 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com"},
    new() {Id = 3 , Name = "Ali" ,Age = 80 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com"},
    new() {Id = 4 , Name = "Salim" ,Age = 11 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com"},
    new() {Id = 5 , Name = "Mohammed" ,Age = 44 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com"},
    new() {Id = 6 , Name = "Abdullah" ,Age = 25 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com"},
    new() {Id = 7 , Name = "khaled",Age = 33 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com"},
    new() {Id = 8 , Name = "Fatima" ,Age = 20 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com"},
};

var SqlQerey = from s in students
             where s.Age > 20
             select s;

var MethodQerey = students.Where(s => s.Age > 20 && s.Gender == false).Select(s=> s);

Student.PrintAll(MethodQerey);