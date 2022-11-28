// See https://aka.ms/new-console-template for more information



// working with Generic type collection 

//int[] arr = {1,2,3,4,5,6,7,8,9,9 };

//Stack<int> stack = new Stack<int>(arr);

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}
// another method to  add and show string typearrays.

//string[] srr = {"shani","isa","shabih","alam","sheraz" };

//var s = new Stack<string>(srr);

//Console.WriteLine("your string names are ");
//foreach (var item in srr)
//{
//    Console.WriteLine(item);

//}


// Queue
//string[] str = { "isa", "kamran", "kaleem" };


//Queue<string> queue = new Queue<string>(str);

//foreach (var item in str)
//{
//    Console.WriteLine(item);
//}

//student a = new student(1, "isa");
//student b = new student(2, "alam");
//student c = new student(3, "sheraz");
//student d = new student(4, "nasir");
//student e = new student(5, "mushahid");
//student f = new student(6, "mehdi");
//student g = new student(7, "sajjad");

//student[] arr = { a, b, c, d, e, f, g };

////Queue<student> arrays = new Queue<student>(arr);
//Queue<student> queue = new Queue<student>(arr);

//queue.Enqueue(a);
//queue.Enqueue(b);
//queue.Enqueue(c);  
//queue.Enqueue(d);
//queue.Enqueue(e);
//queue.Enqueue(f);
//queue.Enqueue(g);

//foreach (student item in queue)
//{
//    Console.WriteLine("student is {0} and name is {1} ",item.id,item.name);
//}


// working with list

//List<int> obj = new List<int>();

//obj.Add(1);
//obj.Add(2);
//obj.Add(3);
//obj.Add(4);


//foreach (var item in obj)
//{
//    Console.WriteLine(item);
//}

//List<string> obj = new List<string>();

//obj.Add("esa");
//obj.Add("shani");
//obj.Add("alam");
//obj.Add("khan");
//obj.Add("wafa");
//obj.Add("dil");
//obj.Add("re");
//obj.Add("ja");
//obj.Add("d");

//foreach (var item in obj)
//{
//    Console.WriteLine(item);
//}

//working with Dictionaris

Dictionary<int, string> obj = new Dictionary<int, string>();
obj.Add(1, "isa");
obj.Add(2, "shani");
obj.Add(3, "dilber");

obj.Add(4, "shani");
obj.Add(5, " karmarn");

//Console.WriteLine(obj[1]);

// print all data using foreach loop

foreach (KeyValuePair<int,string> item in obj)
{
    Console.WriteLine(item);
}
