// See https://aka.ms/new-console-template for more information
using LINQ_01;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

List<Student> students = new() {
    new() {Id = 1 , Name = "Saleh" ,Age = 20 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com" , Level = 5 , Marks = new List<string> {"34","52" } },
    new() {Id = 1 , Name = "Saleh" ,Age = 20 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 5, Marks = new List<string> {"34","52" } },
    new() {Id = 3 , Name = "Ali" ,Age = 80 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 3, Marks = new List<string> {"99","88" } },
    new() {Id = 4 , Name = "Salim" ,Age = 11 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 3, Marks = new List<string> {"45","454" } },
    new() {Id = 5 , Name = "Mohammed" ,Age = 44 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 3, Marks = new List<string> {"5","1" }},
    new() {Id = 6 , Name = "Abdullah" ,Age = 25 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 4, Marks = new List<string> {"7","0" }},
    new() {Id = 7 , Name = "khaled",Age = 33 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 4, Marks = new List<string> {"5","545"}},
    new() {Id = 8 , Name = "Fatima" ,Age = 20 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 4, Marks = new List<string> {"7","58"}},
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

//int[] ints = new int[] { 2, 4, 3, 2 };
//var maxint = ints.Max();
//var maxages = students.Max(s => s.Age);
//Console.WriteLine(maxages);

//it's return the student that have the maxmum age in the list
//var maxagestudent = students.MaxBy(s => s.Age);
//Console.WriteLine(maxagestudentage.Name);


//int[] ints = new int[] { 2, 4, 3, 2 };
//var minint = ints.Min();
//var minages = students.Min(s => s.Age);
//Console.WriteLine(minages);

////it's return the student that have the minmum age in the list
//var minagestudent = students.MinBy(s => s.Age);
//Console.WriteLine(minagestudent.Name);


//string sentence = "the quick brown fox jumps over the lazy dog";

//string[] words = sentence.Split(' ');

//string reversed = words.Aggregate((acc,next) =>
//{
//    Console.WriteLine($"acc = {acc} , next = {next}");
//    return $"{next} {acc}";
//});
//Console.WriteLine(reversed);



//int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };
////here we use seed to start total form zero and next start form 4 the first elment
//int numEven = ints.Aggregate(seed: 0 ,(total,next) =>
//{
//    Console.WriteLine($"total :{total},next :{next} ");
//    return next % 2 == 0 ? total + 1 : total;
//}, result=> result * 10);

//Console.WriteLine($"the number of even intgers is: {numEven}");


//var resultSelect1 = from s in students
//                    select new StudentDto(s.Name, s.Age, s.Level, s.Gender);

//var resultSelect2 = from s in students
//                    select new {s.Name , s.Age ,CurrentLevel = s.Level, s.Gender};

//var resultSelect3 = students.Select(s => new StudentDto($"{s.Name}-{s.Phone}",s.Age,s.Level, s.Gender));

//var resultSelect4 = students.Select(s => new {s.Name,s.Age,s.Level,s.Gender});

//var resultSelect5 = students.Select((s, Index) => new StudentDto($"{s.Name}-{s.Phone}",s.Age,s.Level, s.Gender,Index));

//foreach (var item in resultSelect5)
//{
//    Console.WriteLine(item.Index);
//    Console.WriteLine($"Name:{item.Name}, Age :{item.Age} , Level:{item.Level} ,Gender:{item.Gender}");

//}


//var resultSelectMany1 = students.SelectMany(s=> s.Marks);
//var resultSelectMany2 = students.SelectMany((s,i)=> s.Marks.Select(s=> $"{i}-{s}"));
//var resultSelectMany3 = students.SelectMany(s => s.Marks , (s,m) => new {DisplayValue = $"{s.Name}-{m}"});

//foreach (var item in resultSelectMany2)
//{
//    Console.WriteLine(item);
//}

//var resultSelect3 = students.Select(s => new StudentDto(s.Name, s.Age, s.Level, s.Gender,string.Join(',',s.Marks)));

//foreach (var item in resultSelect3)
//{
//    Console.WriteLine($"Name:{item.Name}, Age :{item.Age} , Level:{item.Level} ,Gender:{item.Gender},Marks : {item.Marks}");

//}


//int[] ints = { 3, 4, 5, 6, 6, 7, 7 };
//var resultDistinct1 = ints.Distinct();
//var resultDistinct2 = students.SelectMany(s => s.Marks).Distinct();
//var resultDistinct3 = students.DistinctBy(s => s.Name);

//foreach (var item in resultDistinct3)
//{
//    Console.WriteLine(item.Name);
//}

//var resultGroups1 = from s in students
//                  group s by s.Level;
//var resultGroups2 = from s in students
//                    group s by new {s.Level ,s.Gender};

//var resultGroups3 = students.GroupBy(s => s.Level);

//foreach (var group in resultGroups2)
//{
//    Console.WriteLine($"Level :{group.Key}");
//    foreach (var Student in group)
//    {
//        Console.WriteLine($"Name ={Student.Name}");
//    }
//}


var resultGroups5 = from s in students
                    group s by new { s.Level, s.Gender }
                    into g
                    select new
                    {
                        g.Key,
                        Students = g,
                        Count = g.Count()
                    };

var resultGroups6 = students.GroupBy(s => new { s.Level, s.Gender }).Select(g => new
{
    g.Key,
    Students = g,
    Count = g.Count()
});

var resultGroups7 = students.GroupBy(s => s.Level,(key,Group) => new
{
    Key = key,
    Students = Group,
    Count = Group.Count()
});
foreach (var group in resultGroups7)
{
    Console.WriteLine($"Level :{group.Key}");
    Console.WriteLine($"Count :{group.Count}");
    foreach (var Student in group.Students)
    {
        Console.WriteLine($"Name = {Student.Name} ,Age = {Student.Age}");
    }
}