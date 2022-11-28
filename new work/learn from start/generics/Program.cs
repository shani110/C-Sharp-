// See https://aka.ms/new-console-template for more information

using generics.com;
using System.Diagnostics.CodeAnalysis;
// printing and assigning arrays without using generic 
int[] arr = {12,4,22,44,56,7,88,9,9 };
//genrics.show(arr);
string[] myarr = {"isa","shani","karamat"};
//genrics.show(myarr);

// generic is used of type safty and it save us from method overloading

//printing int type array with genric method

//genrics.show(arr);

//printing string type array with same above generics type method
//genrics.show(myarr);

// giving int type value to generic class 

//Example<int> obj = new Example<int>(23);

//obj.geta();

//giving stirng type data to generics 

//Example<string> obj1 = new Example<string>("isa");
//obj1.geta();


//Example<string> obj = new Example<string>();

//obj.show = "isa";
//Console.WriteLine(obj.show);


//// giving int value 
//Example<int> obj1 = new Example<int>();
//obj1.show = 23;
//Console.WriteLine(obj1.show);

// delegates 
// delegate are used to call mehtods with calling method name.. 

//calculation obj = new ca lculation(Delegates.add);
//obj.Invoke(23, 43);

//calculation obj2 = obj;
//obj2.Invoke(2, 3);
//calculation obj3;

// Anonymous functiion (function without name. 
//myDelegate obj =  delegate(int a, int b)
//{
//    var c = a + b;
//    Console.WriteLine("function ans is "+c);
//};
//obj(12, 32);
//myDelegate ob = delegate (int a, int b)
//{

//    Console.WriteLine(" value of ist number " + a + " value of 2nd number is " + b);

//};
//ob(102, 232);

//SHOW o = delegate (string s, int a, int b)
//{
//    Console.WriteLine("name of student is " + s);
//    Console.WriteLine("Registration number is " + a);
//    Console.WriteLine("age of student is " + b);
//};
//o("isa", 5532, 23);

// making lambda expression anonymous functon it is used to simplify anonymous function

//SHOW obj = (a,b,c) =>
//{
//    Console.WriteLine(" name is {0} registraion number is {1}, age is {2}",a,b,c);
//};
//obj("shani", 5546, 24);

//// making add mehthod 

//op obj1 = (a, b) => 
//{
//    Console.WriteLine(" ans is "+(a+b));

//};
//obj1.Invoke(12, 2);

// MAKING RETURN TYPE LEMBDA

