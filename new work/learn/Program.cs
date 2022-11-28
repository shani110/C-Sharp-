using System;

namespace learn
{
    class Program
    {
        public const double PI = 3.143;

        static void Main(string[] args)
        {
            // writing and reading in console

            //Console.WriteLine("Enter your name ");
            //string name = Console.ReadLine();

            //Console.WriteLine("your name is : {0}",name);



            // builtin data types. 
            // signed and unsigned

            //un signed datatypes

            //int age = 12;
            //Console.WriteLine(age);

            // signed data types 

            //sbyte age = -12;
            //Console.WriteLine(age);

            //int a = -1212121;
            //Console.WriteLine(a);

            //float, double and decimal

            //float example

            //Console.WriteLine("float range is 7");
            //float a = 993.23232323f;
            //Console.WriteLine("for 993.23232323 no in float it will show "+a);

            // Double example

            //Console.WriteLine("its range is betweeen 15 - 16");

            //double a = 12111111111111.33333333333333333d;
            //Console.WriteLine("12111111111111.33333333333333333d double datatype will show"+a);

            //decimal range is 28-29

            //string and cherctar
            //in string datatype it store multiple charachters 

            //string name = "ali";
            //Console.WriteLine("name is {0} ",name);

            //Escape 
            //Console.WriteLine("in this, if we want to show qutation we use some tecniques\n by which computer can understand and print double qutations");
            //Console.WriteLine("\" we are muslimes \"");

            //verbitem literal 
            //Console.WriteLine("without verbitem literal the below line is if we use \\ n");
            //Console.WriteLine("his name is ali \n he is my good friend \n we usually go to uni together");

            //Console.WriteLine("now with the use of verbitem");
            //Console.WriteLine(@"his name is ali \n he is my good friend \n we usually go to uni together");


            // convertion
            //implicit 

            //int a = 12;
            //float b = a;
            //Console.WriteLine(a);

            //explicit
            //float a = 1232.3232f;
            //first method

            //int b = (int)a;
            //Console.WriteLine("after converting into int the above number is "+b);

            //second method

            //int b = Convert.ToInt32(a);
            //Console.WriteLine("number is "+b);

            //string a = "232";
            //string b = "3223";
            ////int c = Convert.ToInt32(a) + Convert.ToInt32(b);
            //int c = int.Parse(a) + int.Parse(b);
            //Console.WriteLine("result "+c);

            //string a = "12.212";
            //string b = "2323.444";

            //float c = float.Parse(a) + float.Parse(b);
            //Console.WriteLine( "ans is "+c);

            //printdate

            //string date = DateTime.Now.ToShortDateString();
            //Console.WriteLine("current date is "+date);

            // second method

            //DateTime dt = DateTime.Now;
            //Console.WriteLine("Date : {0:d}",dt);
            //Console.WriteLine("Date : {0:D}", dt);
            // Console.WriteLine("Date : {0:F}",dt);
            //Console.WriteLine( "Date : {0:g}",dt);
            //  Console.WriteLine("Date : {0:t}",dt);
            //  Console.WriteLine("date : {0:ddd}",dt);
            //Console.WriteLine("{0:hh:mm:ss:tt}",dt);
            //Console.WriteLine("{0: dd-MM-yyyy}",dt);


            //Console.WriteLine("the value of pi is "+PI);

            //Arthimatic operators

            //Console.WriteLine(  "Find the remainders of 8/3");
            //byte c = 8 % 3;
            //Console.WriteLine("remainder of above experission is "+c);

            //byte a = 12;
            //byte b = 53;
            ////bool c = a == b;
            //bool c = a > b;
            //bool c = a >= b;
            //bool c = a < b;
            //bool c = a <= b;
            //Console.WriteLine(c);

            //conditional operator or logical operators

            ////bool c = a < b && a <= b;
            //bool c = a > b && a >= b;
            //Console.WriteLine(c);

            //assignment operator 
            // compund assignment operators 

            // double a = 8;

            // a += 4;
            //  a -= 3;
            //a *= 2;
            //a /= 2;
            //a %= 3;
            //   Console.WriteLine(a);

            // increment and decriment operator

            //int b  = 8;
            //for post increment 
            // it will show 8 
            //  Console.WriteLine(b++);

            //for pre incriment
            //it will show 9 ans

            //Console.WriteLine(++b);

            // for pre and post decriment

            // ternary or conditional operators
            //Console.WriteLine("Enter your marks out of 100 ");

            //double b = double.Parse(Console.ReadLine());

            //string k = (b >= 50) ? "Congratulations your are pass" : "try next time";
            //Console.WriteLine(k);


            // if else statements

            //int a = 78;
            //if (a > 50) 
            //{
            //    Console.WriteLine("pass");
            //}
            //else
            //    Console.WriteLine("fail");
            //Console.ReadLine();

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
            //            Console.WriteLine("you are student of speridian");
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

            //        {
            //            Console.WriteLine("Enter your bike type ");
            //            string namei = Console.ReadLine();
            //            switch (namei) 
            //            {
            //            case "cd":
            //                        {
            //                        Console.WriteLine("you have cd");
            //                    }
            //                    break;

            //                case "honda":
            //                    {
            //                        Console.WriteLine("you have honda");
            //                    }
            //                    break;

            //                default:
            //                    Console.WriteLine( "out of entery bike");
            //                    break;


            //            }

            //            break;
            //        }


            //    default: {
            //            Console.WriteLine("wrong one");
            //        }
            //        break;
            //}

            // for loop

            //for print first 10 numbers
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("for loops end ");

            //// print first ten numbers using decriment

            //for (int i = 10; i > 0; i--) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("for loop ends again");

            //// printing table using for loop 

            //Console.WriteLine( "Enter a number to print table");

            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("table of {0} is ",n);
            //for (int i = 1; i <= 10; i++) 

            //{
            //    Console.WriteLine(n +" X "+i+ " = "+(n*i));

            //}

            // creating marksheet

            //getting  data
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

            // for continue

            //for (int j = 0; j <= 10; j++)
            //{
            //    if (j == 5)
            //    {
            //        continue;

            //    }
            //    Console.WriteLine(j);

            //}

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


        
           




        } // main method ends here



     
























        //public static void add(int a, int b) 
        //{
        //    int result = a + b;
        //    Console.WriteLine("result is "+result);
        //}


        //public static void sub(int a, int b)
        //{
        //    int result = a - b;
        //    Console.WriteLine("result is " + result);
        //}
        //public static void mult(int a, int b)
        //{
        //    int result = a * b;
        //    Console.WriteLine("result is " + result);
        //}

        //public static void div(int a, int b)
        //{
        //    int result = a / b;
        //    Console.WriteLine("result is " + result);
        //}











        //public static void add(int a, int b) 
        //{
        //    int result = a + b;
        //    Console.WriteLine("Result is "+result);

        //}



        //public void show()
        //    {

        //Console.WriteLine("welcome");
        //    }
        //public static void show1() 
        //{

        //    Console.WriteLine(" this is for testing static methods ");

        //}
    }

}
