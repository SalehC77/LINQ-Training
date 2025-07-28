// See https://aka.ms/new-console-template for more information
using LINQ_01;

Console.WriteLine("Hello, World!");

List<Student> students = new() {
    new() {Id = 1 , Name = "Saleh" ,Age = 20 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com" , Level = 2},
    new() {Id = 2 , Name = "Saleh" ,Age = 24 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 2},
    new() {Id = 3 , Name = "Ali" ,Age = 80 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 3},
    new() {Id = 4 , Name = "Salim" ,Age = 11 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 3},
    new() {Id = 5 , Name = "Mohammed" ,Age = 44 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 3},
    new() {Id = 6 , Name = "Abdullah" ,Age = 25 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 4},
    new() {Id = 7 , Name = "khaled",Age = 33 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 4},
    new() {Id = 8 , Name = "Fatima" ,Age = 20 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 4},
};

//var SqlQerey = from s in students
//             where s.Age > 20
//             select s;

//var MethodQerey = students.Where(s => s.Name == "saleh");

//var WhereQerey = students.Where(s => s.Age > 20 && s.Gender == false);
//Student.PrintAll(WhereQerey);

//var firstQerey = students.First();
//firstQerey = students.First(s => s.Age == 20);

//var firstorDefaultQerey = students.FirstOrDefault();
//firstorDefaultQerey = students.FirstOrDefault(s => s.Age == 20);
//firstorDefaultQerey = students.FirstOrDefault(new Student { Id = 100, Name = "saleh" });
//firstorDefaultQerey = students.FirstOrDefault(s => s.Id == 99, new Student { Id = 100, Name = "saleh" });
//Student.Print(firstorDefaultQerey);

//var lastQerey = students.Last();
//lastQerey = students.Last(s => s.Name == "Omer");

//var lastorDefault = students.LastOrDefault();
//lastorDefault = students.LastOrDefault(s => s.Name == "Omer");
//lastorDefault = students.LastOrDefault(new Student { Id = 100, Name = "saleh" });
//lastorDefault = students.LastOrDefault(s => s.Name == "Omer", new Student { Id = 100, Name = "saleh" });

//var SingleQerey = students.Single();// true just if the list contain one element
//SingleQerey = students.Single(s => s.Id == 2); // true if one element just meet the condition below;

//students = new List<Student>() { new Student() { Name = "saleh" } };
//var SingleOrDefault = students.SingleOrDefault();
//SingleOrDefault = students.SingleOrDefault(s => s.Id == 3);
//SingleOrDefault = students.SingleOrDefault(new Student() { Name = "Default"});
//SingleOrDefault = students.SingleOrDefault(s => s.Id == 3, new Student() { Name = "Default" });


