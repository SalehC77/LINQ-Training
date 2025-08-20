// See https://aka.ms/new-console-template for more information
using LINQ_01;
using System.Collections;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

List<Student> students = new() {
    new() {Id = 1 , Name = "Saleh" ,Age = 20 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com" , Level = 5 , Marks = new List<string> {"34","52" } },
    new() {Id = 2 , Name = "Saleh" ,Age = 22 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 5, Marks = new List<string> {"34","52" } },
    new() {Id = 3 , Name = "Ali" ,Age = 80 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 3, Marks = new List<string> {"99","88" } },
    new() {Id = 4 , Name = "Salim" ,Age = 11 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 3, Marks = new List<string> {"45","454" } },
    new() {Id = 5 , Name = "Mohammed" ,Age = 44 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 3, Marks = new List<string> {"5","1" }},
    new() {Id = 6 , Name = "Abdullah" ,Age = 25 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 4, Marks = new List<string> {"7","0" }},
    new() {Id = 7 , Name = "khaled",Age = 33 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 4, Marks = new List<string> {"5","545"}},
    new() {Id = 8 , Name = "Fatima" ,Age = 30 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 4, Marks = new List<string> {"7","58"}},
};
List<Student> studentsAgain = new() {
    new() {Id = 1 , Name = "Saleh" ,Age = 20 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com" , Level = 5 , Marks = new List<string> {"34","52" } },
    new() {Id = 1 , Name = "Saleh" ,Age = 22 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 5, Marks = new List<string> {"34","52" } },
    new() {Id = 3 , Name = "Ali" ,Age = 80 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 3, Marks = new List<string> {"99","88" } },
    new() {Id = 7 , Name = "khaled",Age = 33 ,Gender = false,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 4, Marks = new List<string> {"5","545"}},
    new() {Id = 8 , Name = "Fatima" ,Age = 30 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 4, Marks = new List<string> {"7","58"}},
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


//var resultGroups5 = from s in students
//                    group s by new { s.Level, s.Gender }
//                    into g
//                    select new
//                    {
//                        g.Key,
//                        Students = g,
//                        Count = g.Count()
//                    };

//var resultGroups6 = students.GroupBy(s => new { s.Level, s.Gender }).Select(g => new
//{
//    g.Key,
//    Students = g,
//    Count = g.Count()
//});

//var resultGroups7 = students.GroupBy(s => s.Level, (key, Group) => new
//{
//    Key = key,
//    Students = Group,
//    Count = Group.Count()
//});
//foreach (var group in resultGroups7)
//{
//    Console.WriteLine($"Level :{group.Key}");
//    Console.WriteLine($"Count :{group.Count}");
//    foreach (var Student in group.Students)
//    {
//        Console.WriteLine($"Name = {Student.Name} ,Age = {Student.Age}");
//    }
//}

//var resultGroups8 = students.GroupBy(GetAgeRange, (key, Group) => new
//{
//    Key = key,
//    Students = Group,
//    Count = Group.Count()
//});
//foreach (var group in resultGroups8)
//{
//    Console.WriteLine($"Age :{group.Key}");
//    Console.WriteLine($"Count :{group.Count}");
//    foreach (var Student in group.Students)
//    {
//        Console.WriteLine($"Name = {Student.Name} ,Age = {Student.Age}");
//    }
//}
//static string GetAgeRange (Student student)
//{
//    var Agerange = Math.Abs(student.Age / 10) * 10;
//    return $"From {Agerange} to {Agerange + 9}";
//}


//List<Employee> employees = new(){
//    new Employee("Ali","HR",60000),
//    new Employee("Hassan","IT",80000),
//    new Employee("Waleed","HR",70000),
//    new Employee("Mazen","IT",90000)


//};

//var salarybyDepartment = employees.GroupBy(e => e.Department,
//    (key, employeesGroup) => new
//    {
//        Department = key,
//        Totalsalaries = employeesGroup.Sum(e => e.Salary)

//    });
//foreach (var item in salarybyDepartment)
//{
//    Console.WriteLine($"Department : {item.Department} , Total Salaries: {item.Totalsalaries}");
//}



//var levelWithMinAndMaxages = students.GroupBy(s => s.Level, (key, group) => new
//{
//    Level = key,
//    MinAgeValue = group.Min(s=> s.Age),
//    MaxAgeValue = group.Max(s=> s.Age)


//}) ;

//foreach (var item in levelWithMinAndMaxages)
//{
//    Console.WriteLine($"level :{item.Level} ,MinValue:{item.MinAgeValue},MaxValue:{item.MaxAgeValue} ");
//}




//var tolookup1 = students.ToLookup(s => s.Level) ;

//foreach (var group in tolookup1)
//{
//    Console.WriteLine(group.Key);
//    foreach (var student in group)
//    {
//        Console.WriteLine($"name :{student.Name},age : {student.Age}");
//    }
//}

//var tolookup2 = students.ToLookup(s => s.Level,s => new StudentDto(s.Name,s.Age,s.Level,s.Gender,"empty"));

//foreach (var group in tolookup2)
//{
//    Console.WriteLine($"level :{group.Key}");
//    foreach (var student in group)
//    {
//        Console.WriteLine($"name :{student.Name},age : {student.Age}");
//    }
//}

//tolookup funcation is immedite excution not defured excution like groupby
//groupby is better in the performance at the level of database to come ready grouping not local like tolookup


// sub the element into supelement like  8 studnets / 2 parts == 4 parts
//var chunks = students.Chunk(2);
//foreach (var chunk in chunks)
//{
//    Student.PrintAll(chunk);
//    Console.WriteLine("****************");
//}


//var takebycount = students.Take(4);
//Student.PrintAll(takebycount);
//Console.WriteLine("***********************");
//var takebyRange = students.Take(new Range(0,5));
//Student.PrintAll(takebyRange);
//Console.WriteLine("***********************");

//var takeLastbycount = students.TakeLast(2);
//Student.PrintAll(takeLastbycount);
//Console.WriteLine("***********************");

//var takewhile1 = students.TakeWhile(s => s.Age > 18);
//Student.PrintAll(takewhile1);

//var takewhile2 = students.TakeWhile((s,i) => i < 5 );
//Student.PrintAll(takewhile2);


//var skip = students.Skip(3);
//Student.PrintAll(skip);

//var skiplast = students.SkipLast(3);
//Student.PrintAll(skiplast);

//var skipwhile = students.SkipWhile(s=> s.Age > 18);
//Student.PrintAll(skipwhile);


//int pageSize = 10;
//int pageNumber = 2;
//var pagination = students.Skip((pageNumber - 1) * pageSize).Take(pageSize);
//Student.PrintAll(pagination);


//var emptylist = Enumerable.Empty<Student>();

//var defaultifempty1 = emptylist.DefaultIfEmpty();
//var defaultifempty2 = students.DefaultIfEmpty();
//var defaultifempty3 = emptylist.DefaultIfEmpty(new Student() { Id = 55 ,Name = "saleh"});
//Student.PrintAll(defaultifempty3);


//var elementAt1 = students.ElementAt(1);
//Student.Print(elementAt1);
//var elementAt2 = students.ElementAt(new Index (2));
//Student.Print(elementAt2);
//var elementAt3 = students.ElementAt(new Index (1,true));
//Student.Print(elementAt3);

//int[] ints = {};
//Console.WriteLine(ints.ElementAtOrDefault(2));
//var elementAtOrDefault1 = students.ElementAtOrDefault(18);
//Student.Print(elementAtOrDefault1);
//var elementAtOrDefault2 = students.ElementAtOrDefault(new Index(0,true));
//Student.Print(elementAtOrDefault2);


// in dotnet 9,10
//var Index = students.Index();
//foreach (var student in Index)
//{
//    Console.WriteLine($"index:{student.Index}: car:{student.Item}");
//}

//var Concatlist = students.Concat(students);
//Student.PrintAll(Concatlist);


// here we implemention the IEquatable interface for the class student to let Union work fine
//var Union = students.Union(studentsAgain);
//Student.PrintAll(Union);

//var Unionby = students.UnionBy(studentsAgain,s => s.Id);
//Student.PrintAll(Unionby);



//int[] ints1 = { 1, 2, 3, 4, 5 };
//string[] words1 = { "one", "tow", "three", "four", "five" };

//var zip1 = ints1.Zip(words1);
//foreach (var (First,Second) in zip1)
//{
//    Console.WriteLine($"first:{First}, Second:{Second}");
//}
//Hint: there also another overload for zip method that take three tuple mean three list

//int[] ints2 = { 1, 2, 3, 4, 5 };
//string[] words2 = { "one", "tow", "three", "four", "five" };

//var zip2 = ints2.Zip(words2,(numbers,words) => $"{numbers} -- {words}");
//var zip3 = ints2.Zip(words2,(numbers,words) => new { Number = numbers, Word = words});
//foreach (var item in zip2)
//{
//    Console.WriteLine($"Item : {item}");
//}
//foreach (var item in zip3)
//{
//    Console.WriteLine($"{item.Number} -- {item.Word}");
//}


//var StudentAsArray = students.ToArray();
//for (int i = 0; i < StudentAsArray.Length; i++)
//{
//    Console.WriteLine($"{StudentAsArray[i].Name} , {StudentAsArray[i].Age}");
//}

//var StudentAsDictionary1 = students.ToDictionary(s => s.Id);
//var StudentAsDictionary2 = students.ToDictionary(s => s.Id,s => $"{s.Name} - {s.Age}");
//foreach (var item in StudentAsDictionary2)
//{
//    Console.WriteLine($"Key :{item.Key}");
//    //Console.WriteLine($"value :{item.Value.Name}");
//    Console.WriteLine($"value :{item.Value}");
//}


//var StudentAsHashSet = students.ToHashSet();
//foreach (var item in StudentAsHashSet)
//{
//    Console.WriteLine(item.Name);

//}
//// here the tolist methode make the Excution of where Immedite not defured
//var StudentAsTolist1 = students.Where(s => s.Level > 2).ToList();
//var StudentAsTolist2 = students.ToList();
//foreach (var item in StudentAsTolist2)
//{
//    Console.WriteLine(item.Name);
//}


List<Make> makes = new()
{
    new Make(1,"Ford"),
    new Make(2,"chevrolet"),
    new Make(3,"toyota"),
    new Make(4,"honda"),
    new Make(5,"Nissan"),
    new Make(6,"mercury"),
};
List<Model> models = new()
{
    new Model(1,"Gt",1),
    new Model(2,"Mystique",6),
    new Model(3,"Maxima",5),
    new Model(4,"Mariner",6),
    new Model(5,"Mr2",3),
    new Model(6,"Malibu",2),
};

List<Car> cars = new()
{
    new Car(1,1,1,"ajifolasalfkf"),
    new Car(2,6,4,"sdssafasfas"),
    new Car(3,2,6,"safdasfsadfa"),
    new Car(4,4,7,"sdfdfsdgfd"),
    new Car(5,3,5,"dsgsdggsgd"),
    new Car(6,5,3,"dfsvgsddsgd"),
};

//var resultJoin1 = from car in cars
//                 join make in makes
//                 on car.MakeId equals make.Id
//                 join model in models 
//                 on car.ModelId equals model.Id
//                 select new
//                 {
//                     car.Id,
//                     Make = make.Name,
//                     Model = model.Name,
//                     car.VIN
//                 };
//Console.WriteLine("hello");

//var resultJoin2 = cars.Join(makes,car => car.Id,make => make.Id,
//                (car,make) => new
//                {
//                   car.Id,
//                   Make = make.Name,
//                   ModelId = car.ModelId,
//                   car.VIN
//                }
//                ).Join(models,car => car.ModelId,model => model.Id,
//                (car,model) => new
//                {
//                    car.Id,
//                    car.Make,
//                    Model = model.Name,
//                    car.VIN
//                }


//    );

//var resultJoingroup3 = from make in makes
//                  join model in models
//                     on make.Id equals model.MakeId
//                     into groupModels
//                  where groupModels.Any()
//                  select new
//                  {
//                      Make = make.Name,
//                      Models = groupModels.Select(m => m.Name),
//                      ModelCount = groupModels.Count()

//                  };


//var resultJoingroup4 = makes.GroupJoin(models,make => make.Id , model => model.Id,
//                        (make,model) => new
//                        {
//                            Make = make.Name,
//                            Models = model.Select(m => m.Name),
//                            ModelsCount = model.Count()
//                        }).Where(x => x.Models.Any());


//var resultLeftJoin1 = from make in makes
//                      join model in models
//                      on make.Id equals model.MakeId
//                       into groupmodels
//                      from gm in groupmodels.DefaultIfEmpty()
//                      select new 
//                      { 
//                        Make = make.Name,
//                        Model = gm?.Name
//                      }
//                      ;

//var resultLeftJoin2 = from car in cars
//                      join model in models
//                      on car.ModelId equals model.Id
//                         into groupmodels
//                      from gm in groupmodels.DefaultIfEmpty()
//                      select new
//                      {
//                          car.Id,
//                          gm?.Name
//                      };


//var resultLeftJoin3 = makes.GroupJoin(models, make => make.Id, model => model.Id,
//                        (make, models) => new
//                        {
//                            Make = make.Name,
//                            Models = models

//                        }).SelectMany(
//                            gm => gm.Models.DefaultIfEmpty(),
//                            (make, model) => new
//                            {
//                                Make = make.Make,
//                                Model = model?.Name

//                            });



//int[] ints = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//var isExists1 = ints.Contains(4);


//var newstudentSameAsinlist = new Student() { Id = 1, Name = "Saleh", Age = 20, Gender = true, Phone = "774361224", Gmail = "salehbenjahlan@gmail.com", Level = 5, Marks = new List<string> { "34", "52" } };
//var isExists2 = students.Contains(newstudentSameAsinlist);
//Console.WriteLine(isExists2);



//int[] selectedIds = new[] { 7, 2, 1, 3, 4 };
//var selectedStudent = students.Where(s => selectedIds.Contains(s.Id));
//Student.PrintAll(selectedStudent);



//int[] numbers1 = new int[] { 1, 2, 3, 4, 5 };
//int[] numbers2 = new int[] { 1, 2, 6, 4, 5 };

//var intersect1 = numbers1.Intersect(numbers2);
//foreach (var item in intersect1)
//{
//    Console.WriteLine(item);
//}



// here we use  IEquatable<Student>  to give clear result;
//var intersect2 = students.Intersect(studentsAgain);
//Student.PrintAll(intersect2);

//var intersectby1 = students.IntersectBy(studentsAgain.Select(s => new { s.Id ,s.Name}),s => new {s.Id,s.Name});
//Student.PrintAll(intersectby1);


//int[] numbers1 = new int[] { 1, 2, 3, 4, 5 };
//int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };

//var result1 = numbers1.SequenceEqual(numbers2);
//var result2 = numbers1.Order().SequenceEqual(numbers2.Order());

//Console.WriteLine($"result1:{result1},result2:{result2}");


//int[] numbers1 = new int[] { 1, 2, 9, 8, 5 };
//int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };

//var resultExcpet1 = numbers1.Except(numbers2);
//foreach (var item in resultExcpet1)
//{
//    Console.WriteLine(item);
//}


//var resultExcpet2 = students.Except(studentsAgain);
//Student.PrintAll(resultExcpet2);

//var resultExcpetBy = students.ExceptBy(studentsAgain.Select(s => s.Id), s => s.Id);
//Student.PrintAll(resultExcpetBy);


//ArrayList arrayList = new()
//{
//  "saleh",
//  3,
//  4,
//  "ahmed",
//  new Student(){Id = 1 , Name = "Saleh" ,Age = 20 ,Gender = true,Phone = "774361224", Gmail = "salehbenjahlan@gmail.com" , Level = 5 , Marks = new List<string> {"34","52" } }

//};

//var stringsonly = arrayList.OfType<string>();
//var intsonly = arrayList.OfType<int>();
//var studentsonly = arrayList.OfType<Student>();

//foreach (var item in stringsonly)
//{
//    Console.WriteLine(item);
//}


//var range = Enumerable.Range(1, 10);
//foreach (var item in range)
//{
//    Console.WriteLine(item);
//}

//var repeat = Enumerable.Repeat("saleh", 10);
//foreach (var item in repeat)
//{
//    Console.WriteLine(item);
//}


//int[] numbers = new int[] { 1, 2, 9, 8, 5 };
//var ReversResult = numbers.Reverse();
//foreach (var item in ReversResult)
//{
//    Console.WriteLine(item);
//}

//before .Net 10
//var result = students.OrderBy(s => Guid.NewGuid());

//after . Net 10
//var result = students.Shuffle().Take(5);





