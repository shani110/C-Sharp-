// See https://aka.ms/new-console-template for more information

// if else statements

//int a = 78;
//if (a > 50)
//{
//    Console.WriteLine("pass");
//}
//else
//    Console.WriteLine("fail");

// a program to login 

//string name, password;
//Console.WriteLine("Enter you name " );
//name = Console.ReadLine();
//Console.WriteLine("Enter your password");
//password = Console.ReadLine();

//if (name == "muhammad" && password == "isa")

//{
//    Console.WriteLine("logging in succesfully");

//}
//else
//{
//    Console.WriteLine("either password or name is not correct");
//}

//Console.WriteLine("Enter your percentage ");
//double a = double.Parse(Console.ReadLine());
//if (a >= 80)
//{ Console.WriteLine("A+"); }
//if (a >= 70)
//{ Console.WriteLine("A"); }
//if (a >= 60)
//{ Console.WriteLine("B"); }
//if (a >= 50)
//{ Console.WriteLine("C"); }
//if (a >= 40)
//{ Console.WriteLine("D"); }

//else 
//{
//    Console.WriteLine("fail");
//}

//  Console.WriteLine("Enter your percentage ");
//  double a = double.Parse(Console.ReadLine());
//  if (a >= 80)
//  { Console.WriteLine("A+"); }
//  else if (a >= 70)
//  { Console.WriteLine("A"); }
//else  if (a >= 60)
//  { Console.WriteLine("B"); }
//else  if (a >= 50)
//  { Console.WriteLine("C"); }
//else  if (a >= 40)
//  { Console.WriteLine("D"); }

//  else
//  {
//      Console.WriteLine("fail");
//  }

//outlook login concept using nested if 

//Console.WriteLine("Enter you mail");
//string mail = Console.ReadLine();
//if (mail == "m.isa@gmail.com")

//{
//    Console.WriteLine("Enter your password ");
//    string password = Console.ReadLine();
//    if (password == "110")
//    {
//        Console.WriteLine("log in successfully");


//    }
//    else 
//    {
//        Console.WriteLine("password error");
//    }
//}
//else 
//{
//    Console.WriteLine("wrond email address");
//}

// switch case 

//string name;
//Console.WriteLine("Enter your name ");
//name = Console.ReadLine();
//switch (name) 

//{
//    case "isa":


//            Console.WriteLine(  "welcome essa");
//            break;

//    case "shabii":


//            Console.WriteLine("Welcome shabii");
//            break;


//    default: 
//        {
//            Console.WriteLine("you are not student of speridian");
//            break;
//        }

//}


//nested switch statement
//string name;
//Console.WriteLine("Enter name of vehical type");
//name = Console.ReadLine();

//switch (name) 

//{
//    case "cars": {
//            Console.WriteLine("cars");
//            break;
//        }
//    case "bike":

//{
//Console.WriteLine("Enter your bike type ");
//string namei = Console.ReadLine();
//switch (namei)
//{
//    case "cd":
//        {
//            Console.WriteLine("you have cd");
//        }
//        break;

//    case "honda":
//        {
//            Console.WriteLine("you have honda");
//        }
//        break;

//    default:
//        Console.WriteLine("out of entery bike");
//        break;


//}


// for loop

//printing  first 10 numbers

//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i);

//}

//Console.WriteLine("for loops ends ");

// print first ten numbers using decriment

//for (int i = 10; i > 0; i--) 
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("for loop ends again");

// printing table using for loop 

//Console.WriteLine( "Enter a number to print table");

//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("table of {0} is ",n);

//for (int i = 1; i <= 10; i++) 

//{
//    Console.WriteLine(n +" X "+i+ " = "+(n*i));

//}

// creating marksheet

//getting  student information from user 

//Console.WriteLine("Enter your name ");
//string name = Console.ReadLine();

//Console.WriteLine("Enter your roll number ");
//int r = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter your class ");
//int c = int.Parse(Console.ReadLine());

////academic data
//Console.WriteLine("Enter your marks is phy ");
//int p = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter your marks in urdu ");
//int u = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter your marks in che ");
//int ch = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter your marks in isl ");
//int isl = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter your marks in eng ");
//int e = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter your marks in math ");
//int m = int.Parse(Console.ReadLine());

//int total = p + u + ch + isl + e + m;
//int percentage = total / 600 * 100;

//Console.WriteLine("Name :"+name);
//Console.WriteLine("Class: "+c);
//Console.WriteLine("roll no: "+r);

//Console.WriteLine("your total marks are "+total);
//Console.WriteLine("percentage = "+percentage);
//if (percentage > 40)
//{
//    Console.WriteLine("you are pass: weldone");
//}
//else
//{
//    Console.WriteLine("better luck next time.");
//}

//usinng 'continue' in for loop it will skip the number which matched the condition 

//for (int j = 0; j <= 10; j++)
//    {
//        if (j == 5)
//        {
//            continue;

//        }
//        Console.WriteLine(j);

//    }

//for (int j = 0; j <= 10; j++)
//{
//    if (j == 5)
//    {
//        break;

//    }
//    Console.WriteLine(j);

//}

//    for (int j = 0; j <= 10; j++)
//    {
//        if (j == 5)
//        {

//            goto aku;
//        }
//        Console.WriteLine(j);

//    }

//aku:
//    { Console.WriteLine("terminated"); }


// using do while loop to make repeatable program

//string put;
//do
//{
//    Console.WriteLine("Enter your name ");
//    string name = Console.ReadLine();

//    Console.WriteLine("your name is " + name);

//    Console.WriteLine("Do you want to continue yes or no");
//    put = Console.ReadLine().ToLower();


//}
//while (put == "yes");

//while (true) 
//{
//    Console.WriteLine("enter your name ");
//    string name = Console.ReadLine();
//    Console.WriteLine("Do you want to continue");
//    string confirm = Console.ReadLine().ToLower();

//    if (confirm == "yes")
//    {
//        continue;
//    }
//    else
//        break;



//}

// array decleration 


//int[] arr = new int[4];
//arr[0] = 23;
//arr[1] = 25;
//arr[2] = 24;
//arr[3] = 27;

//Console.WriteLine(arr[3]);



// method 2
//int[] arr = new int[] {33,4,5,6,7,78 };
//Console.WriteLine(arr[3]);


//method 3

//string[] arr = {"ali ", "zain","rehmat","akram" };
//Console.WriteLine(arr[0]);

//printing an array using for loop

//int[] arr =  { 1, 3, 4, 56, 7, 8, 9, 2 };
//for (int i = 0; i < arr.Length; i++) 
//{
//    Console.WriteLine(arr[i]);
//    Console.WriteLine();
//}

//for each loop

//string[] students = {"ali ", "akrma","beenish","esa","tehsen","sidra" };

//foreach (string item in students)
//{
//    Console.WriteLine(item);
//}


//dyanamic array

//declare 




//int[,] arr = new int[2, 3]
//{
//    {1,2,4 },
//    { 2,34,5}

//};


//Console.WriteLine(arr[0,2]);


// using nested for loop to print dyanamic array

//int[,] arr = new int[3, 4] 
//{
//{1,2,34,5 },
//{2,31,4,52 },
//{3,4,5,6 }

//};
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.Write(arr[i, j] +" ");
//    }

//    Console.WriteLine();
//}

//int[,] arr = new int[2, 4]
//{
//    {1,3,5,7 },
//    {2,4,6,8 }


//};


//foreach (int item in arr)
//{
//    Console.Write(item);
//}

//jagged array .. coloumn is not fixed

//int[][] arr = new int[2][];
//arr[0] = new[] { 1, 3, 4 };
//arr[1] = new[] { 2, 33, 4, 4, 55, 6, 7, 7 };

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr[i].Length; j++)
//    {
//        Console.Write(arr[i][j]);

//    }
//    Console.WriteLine();
//}
//foreach (int[] item in arr)
//{
//    foreach (int i in item) 
//    {
//        Console.WriteLine(i + " ");
//    }

//}

// taking input from user in arrays. 
//Console.WriteLine("enter number of students in your class");
//int a = int.Parse(Console.ReadLine());

//string[] arr = new string[a];
//for (int i = 0; i < a; i++) 
//{
//    Console.WriteLine("Enter student name on location " + (i + 1));
//    string name = Console.ReadLine();
//    arr[i] = name;


//}
//foreach (string item in arr)
//{
//    Console.WriteLine(item);
//}



//}
//Program obj = new Program();

//obj.show();
//Program.show1();

//Console.WriteLine("enter first number ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter 2nd program");
//int b = int.Parse(Console.ReadLine());
//Program.add(a, b);
//Console.WriteLine("Enter first number ");
//int c = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter second nunber ");
//int d = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter operation, you want to perform  +,/,+,-");
//string op = Console.ReadLine();
//switch (op) 
//{

//    case "+":
//        Program.add(c,d);
//        break;
//    case "-":
//        Program.sub(c,d);
//        break;

//    case "/":
//        Program.div(c,d);
//        break;
//    case "*":
//        Program.mult(c,d);
//        break;
//    default:
//        Console.WriteLine("Wrong entery");
//        break;


//}