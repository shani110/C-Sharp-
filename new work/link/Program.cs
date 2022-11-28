// See https://aka.ms/new-console-template for more information

// printing elements from array using linq
// link are used to access data from data source

//int[] arr = { 12, 3, 4, 5, 6, 767, 23, 4, 5, 67, 7, 2 };

//var a = from i in arr where i > 5 orderby arr ascending select i;

//// printing data
//foreach (var item in a)
//{ 
//    Console.WriteLine(item);
//}

// working with student array

using link.com.information;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Net.Cache;
using System.Runtime.CompilerServices;



//List<student> list = new List<student>(students);

//foreach (var item in list)
//{
//    Console.WriteLine("id is {0} , name is {1} age is {2}",item.Id, item.Name, item.Age);
//}

//list = (from obj in students select obj).ToList();

//foreach (var item in list)
//{
//    Console.WriteLine("id is {0} , name is {1} age is {2}", item.Id, item.Name, item.Age);
//}

// printing single coloumn 
//foreach (var o in list)
//{
//    Console.WriteLine("name is "+ o.Name);
//}

//using order by 

//int[] arr = { 12, 3, 4, 5, 6, 767, 23, 4, 5, 67, 7, 2 };

//var a = from i in arr orderby i ascending select i;

// printing data
//foreach (var item in a)
//{
//    Console.WriteLine(item);
//}

//printing in decsending order 

//var b = from k in arr where k > 3 orderby arr descending select k;

//student[] std =
//{
//   new student(1,"isa",21),
//   new student(2,"akram",22),
//   new student(3,"shani",23),
//   new student(4,"kaleem",24),
//   new student(5,"hussain",26),
//   new student(6,"hassan",15),
//   new student(7,"wajid",25),
//};

//calling by method

//var teenAgerStudents = std.Where(s => s.Age > 13 && s.Age < 25);

//var getOldStudetn = std.Where( g => g.Age >22 && g.Age < 24);

//foreach (var item in getOldStudetn)
//{
//    Console.WriteLine(item.Name);

//}

//IEnumerable<student> a= from i in std where i.Id > 3 select i;

//foreach (var item in a)
//{
//    Console.WriteLine(item.Name);
//}


//foreach (var item in std)
//{
//    Console.WriteLine("Id is {0}, Name is {1}, age {2}", item.Id, item.Name, item.Age);
//}


//int[] arr = {1,2,3,4,5,6,7,8};

//List<int> a = new List<int>(arr);
//foreach (var item in a)
//{
//    Console.WriteLine(item);
//}
//var a = from i in arr where i > 3 select i;

//foreach (var item in a)
//{
//    Console.WriteLine(item);

//}

//Linq methods 

// using thenby in linq
student a = new student(1, "isa", 18);
student b = new student(2, "isa", 18);
student c = new student(3, "nayer", 18);
student d = new student(4, "farida", 20);
student e = new student(5, "beenish", 20);
student g = new student(6, "kamran", 20);
student h = new student(7, "shabi", 23);
student i = new student(8, "waqas", 23);
student j = new student(9, "haider", 23);
student l = new student(10, "ali", 23);
student k = new student(11, "zainag", 20);

student[] students = { a, b, c, d, e, g, h, i, j, k };

//IEnumerable<student> obj = students;

//foreach (var item in obj)
//{
//    Console.WriteLine(item.Name);

//}
//var thenByResult = students.OrderBy (s => s.Name ).ThenBy(s => s.Age);
//foreach (var item in thenByResult)
//{
//    Console.WriteLine("name is "+item.Name + " age is "+ item.Age);
//}

//printing by group 
//var groupedResult = from s in students
//                    group s by s.Age;

//iterate each group        
//foreach (var ageGroup in groupedResult)
//{
//    Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

//    foreach (student s in ageGroup) // Each group has inner collection
//        Console.WriteLine("Student Name: {0}", s.Name);
//}

//IList<string> strList1 = new List<string>() {
//    "One",
//    "Two",
//    "Three",
//    "Four"
//};
//IList<string> strList2 = new List<string>() {
//    "One",
//    "Two",
//    "Five",
//    "Six"
//};
//var innerJoin = strList1.Join(strList2,
//                      a => a,
//                      b => b,
//                      (a, b) => a);

//foreach (var item in innerJoin) 

//{
//    Console.WriteLine(item);

//}


//List<int> numbers = new List<int>() {36, 71, 12,
//                             15, 29, 18, 27, 17, 9, 34};

// foreach loop to display the list
Console.Write("The list : ");
//foreach (var value in numbers)
//{
//    Console.Write("{0} ", value);
//}
//Console.WriteLine();

// Using lambda expression
// to calculate square of
// each value in the list
//var square = numbers.Select(x => x * x);
// foreach loop to display squares
//Console.Write("Squares : ");
//foreach (var value in square)
//{
//    Console.Write("{0} ", value);
//}
//Console.WriteLine();

//var details = students.OrderByDescending(x => x.Id);

//foreach (var item in details)
//{
//    Console.WriteLine("name is "+item.Name + " id is "+ item.Id);
//}

//var teenAger = students.Select(s => s.Age > 12 && s.Age < 20);

//foreach (var item in teenAger)
//{

//}




//var details = from s in students where s.Age < 20 && s.Age > 12 select s.Name;

//foreach (var item in details)
//{
//    Console.WriteLine("Teen agers are  "+item);
//}
//var teenAger = from s in students.Where(s => s.Age > 20 && s.Age < 24) select s.Name;



//foreach (var item in teenAger)
//{
//	string name = item.ToString();
//	Console.WriteLine("names is "+name);
//}

// working with regression funciton 

//var maxValue = (from s in students select s.Id).Max();
//Console.WriteLine(" maximum value is "+ maxValue);

//var minvalue = (from s in students where i.Age > 20 select i.Age).Min();

//Console.WriteLine("min age is "+ minvalue);


//Func<student, bool> isTeenAger = delegate (student s) {
//    return s.Age > 12 && s.Age < 20;
//};
//var filteredResult = from s in students
//                     where isTeenAger(s)
//                     select s;

//foreach (var item in filteredResult)
//{
//    Console.WriteLine("name "+item.Name + " age is "+ item.Age);
//}

// use where with lambda expression'

//var result = students.Where(s => s.Age > 12 && s.Age < 20);

//foreach (var item in result)
//{
//    Console.WriteLine("names are "+item.Name);
//}
//

// using oftype 

//oftype will return of given type that is of int or string extra... 

//IList mixedList = new ArrayList();
//mixedList.Add(0);
//mixedList.Add("One");
//mixedList.Add("Two");
//mixedList.Add(3);

//var stringResult = from s in mixedList.OfType<string>()
//                   select s;

//var intResult = from s in mixedList.OfType<int>()
//                select s;

//foreach (var item in stringResult)
//{
//    Console.WriteLine(item);
//}

// using order by 

//var details = from obj in students orderby obj.Age select obj.Name;
//foreach (var item in details)
//{
//    Console.WriteLine(item.ToString());

//}

// orderby descending

//var details = from obj in students orderby obj.Age  descending select obj.Name;

//foreach (var item in details)
//{
//    Console.WriteLine(item.ToString());
//}

// group by 

//var details = from obj in students group obj by obj.Age;

//foreach (var item in details)
//{
//    Console.WriteLine("number of groups are "+item.Count());
//}

//foreach (var item in details)
//{
//    Console.WriteLine(item.Key);

//}

// join in linq
// join is working inner join

List<int> mylist = new List<int>();
mylist.Add(1);
mylist.Add(2);
mylist.Add(3);
mylist.Add(4);
mylist.Add(5);
mylist.Add(6);
mylist.Add(7);
mylist.Add(8);
mylist.Add(9);

List<int> mylist1 = new List<int>();
mylist1.Add(1);
mylist1.Add(21);
mylist1.Add(32);
mylist1.Add(4);
mylist1.Add(53);
mylist1.Add(64);
mylist1.Add(76);
mylist1.Add(8);
mylist1.Add(9);


//var innerjoin = mylist.Join(mylist1,

//    a => a,
//    b=>b,
//    (a,b) => a
//    );

//foreach (var item in innerjoin)
//{
//    Console.WriteLine(item);

//}
//IList<Student> studentList = new List<Student>() {
//    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
//    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
//    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
//    new Student() { StudentID = 4, StudentName = "Ram",  StandardID =2 },
//    new Student() { StudentID = 5, StudentName = "Ron" }
//};

//IList<Standard> standardList = new List<Standard>() {
//    new Standard(){ StandardID = 1, StandardName="Standard 1"},
//    new Standard(){ StandardID = 2, StandardName="Standard 2"},
//    new Standard(){ StandardID = 3, StandardName="Standard 3"}
//};

//var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
//                                std => std.StandardID, //outerKeySelector 
//                                s => s.StandardID,     //innerKeySelector
//                                (std, studentsGroup) => new // resultSelector 
//                                {
//                                    Students = studentsGroup,
//                                    StandarFulldName = std.StandardName
//                                });

//foreach (var item in groupJoin)
//{
//    Console.WriteLine(item.StandarFulldName);

//    foreach (var stud in item.Students)
//        Console.WriteLine(stud.StudentName);
//}

// select new in linq
//var selectResult = from s in students
//                    select new { Name = "Mr. " + s.Name, Age = s.Age };

//foreach (var item in selectResult)
//    Console.WriteLine("Student Name: {0}, Age: {1}", item.Name, item.Age);

//var result1 = from obj in students select new {Name = "Hell "+obj.Name, Age = obj.Age + 22 };

//foreach (var item in result1)
//{
//    Console.WriteLine("*** "+item.Name + " your new age is "+item.Age);
//}

// quantifier operator any, all and contain
// all operator statisy that all element statisfy condition

//bool abc = students.All(s => s.Age > 18 && s.Age < 45);
//Console.WriteLine(abc); // returns false 

// check for any operator 
//bool abc = students.Any(s => s.Age > 18 && s.Age < 45);
//Console.WriteLine(abc); returns true

//IList<int> list = new List<int>() {1,3,4,5,6 };

//bool abc = list.Contains(3);
//Console.WriteLine(abc);

// Aggregateion operators 

//IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

//var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);

//Console.WriteLine(commaSeperatedString);

//IList<int> mylist2 = new List<int>() { 10, 20, 30, 40, 50 };

//var details = mylist2.Average();
//Console.WriteLine(details);

// Element operators 

//var abc = mylist1.Last();
//Console.WriteLine(abc);

// single 

//IList<int> oneElementList = new List<int>() { 7 };
//IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
//IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
//IList<string> emptyList = new List<string>();

//Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
//Console.WriteLine("The only element in oneElementList: {0}",
//             oneElementList.SingleOrDefault());

//Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

//Console.WriteLine("The only element which is less than 10 in intList: {0}",
//intList.Single(i => i < 10));


// linq equality operator 

//IList<string> ab = new List<string>() { "One", "Two", "Three", "Four", "Three" };

//IList<string> ba = new List<string>() { "One", "Two", "Three", "Four", "Three" };

//bool abc = ab.SequenceEqual(ba);
//Console.WriteLine(abc);

// concatenation operators 
//IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
//IList<string> collection2 = new List<string>() { "Five", "Six" };

//var list = collection1.Concat(collection2).ToList();

//foreach (var item in list)
//{
//    Console.WriteLine(item.ToString());
//}

//IList<string> emptyList = new List<string>();

//var newList1 = emptyList.DefaultIfEmpty();
//var newList2 = emptyList.DefaultIfEmpty("None");

//Console.WriteLine("Count: {0}", newList1.Count());
//Console.WriteLine("Value: {0}", newList1.ElementAt(0));

//Console.WriteLine("Count: {0}", newList2.Count());
//Console.WriteLine("Value: {0}", newList2.ElementAt(0));

// Distint() 




//except 
//IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
//IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

//var result = strList1.Except(strList2);

//foreach (string str in result)
//    Console.WriteLine(str);


// intersect
//IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
//IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

//var result = strList1.Intersect(strList2);

//foreach (string str in result)
//    Console.WriteLine(str);
// union same as intersetion

//skip it split the collection into two parts and return one part after given index

//IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

//var details = strList2.Skip(2);
//foreach (string str in details)
//    Console.WriteLine(str.ToString());

//IList<string> strList = new List<string>() {
//                                            "One",
//                                            "Two",
//                                            "Three",
//                                            "Four",
//                                            "Five",
//                                            "Six",
//                                            "seven",
//                                            "eight"
//                                             };

//var resultList = strList.SkipWhile(s => s.Length < 4);

//foreach (string str in resultList)
//    Console.WriteLine(str);


//take operator.. it take elements equal of given index

//var details = strList.Take(2);
//foreach (var item in details)
//{
//    Console.WriteLine(item);

//}

