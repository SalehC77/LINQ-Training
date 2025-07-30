// See https://aka.ms/new-console-template for more information
using LINQ_01;

Console.WriteLine("Hello, World!");

List<Student> students = new() {
    new() {Id = 1 , Name = "Saleh" ,Age = 20 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com" , Level = 5},
    new() {Id = 1 , Name = "Saleh" ,Age = 20 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 5},
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
//SingleOrDefault = students.SingleOrDefault(new Student() { Name = "Default" });
//SingleOrDefault = students.SingleOrDefault(s => s.Id == 3, new Student() { Name = "Default" });


//var orderby = from s in students
//              orderby s.Level descending
//              select s;
//var orderbyascending = students.OrderBy(s => s.Level);
//var orderbyDescending = students.OrderByDescending(s => s.Level);
//Student.PrintAll(orderbyDescending);

//var orderbythenby1 = from s in students
//                    orderby s.Level, s.Id, s.Age descending
//                    select s;
//var orderbythenby2 = students.OrderBy(s => s.Age).ThenBy(s => s.Id).ThenByDescending(s => s.Level);
//Student.PrintAll(orderbythenby2);



//int[] numbers = new int[] { 5, 3, 85,52 };

//var result = numbers.Order();
// result = numbers.OrderDescending();
//foreach (var item in result)
//{
//    Console.WriteLine(item );
//}

//var Order = students.Order(); // this will throw expetion Icomparer interface is not implemented;
//var OrderIcomparer = students.Order(comparer: new StudentComparer());

//Student.PrintAll(Order);



//var any = students.Any();// if not empty return true ; else return false
//Console.WriteLine(any ? "found":"not found");

//var anywithcondition = students.Any(s => s.Level > 4);
//Console.WriteLine(anywithcondition ? "found" : "not found");

//var all = students.All(s => s.Level > 1) ; all element meet the condition;
//Console.WriteLine(all);

//Student newtoappend = new Student { Name = "salim" };
//var Append = students.Append(newtoappend);// to add in the end of list;
//var prepend = students.Prepend(newtoappend);// to add in the front of list;


//var totalcount = students.Count();
//Console.WriteLine($"total count of student : {totalcount}");

//var totalcountfor = students.Count(s => s.Level > 3);
//Console.WriteLine($"total count of student : {totalcountfor}");

////mybe if you need more than int32 bit for return the count of elment there is mehode call longCount to return int64 bit ;
//var longCount = students.Count(s => s.Level > 3);
//Console.WriteLine($"total longCount of student : {longCount}");


// there is anther method call CountBy() in .Net Core 9 
//var levelsCount = students.CountBy(s => s.level);
//var levelsCount2 = students.CountBy(s => $"{s.level}-{s.Gender}"); it's give you how many in the level in each Gender
//foreach (var level in levelsCount)
//{
//    Console.WriteLine($"{level.key}--> {level.value}");
//}


//var sumwithcondition = students.Where(s => s.Gender == true).Sum(s=> s.Age);
//Console.WriteLine(sumwithcondition);
// it's return the sum of ages for all male student;


//int[] ints = new int[] { 2, 4, 3, 2 };
//var avarageint = ints.Average();
//var avarage = students.Average(s => s.Age);
//Console.WriteLine(avarage);




















