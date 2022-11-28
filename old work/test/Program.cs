using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int age;
            int no;
            string o;


            // using do while loop

            do
            {
                Console.WriteLine("enter your age");
                age = int.Parse(Console.ReadLine());

                // using if else loop

                if (age > 10 && age < 20)
                {
                    Console.WriteLine("your are teen ager, you can watch cartoons   ");
                    Console.WriteLine("press 1 for tom and jeryy,\n 2 for moto patlo \n 3 for rudra ");
                    no = int.Parse(Console.ReadLine());

                    //using switch loop 

                    switch (no)
                    {
                        case 1:
                            Console.WriteLine(" watching tom and jerry ");
                            break;
                        case 2:
                            Console.WriteLine(" wathing moto patlo");
                            break;
                        case 3:
                            Console.WriteLine("watching rudra");
                            break;
                        default:
                            Console.WriteLine("wrong entery");
                            break;

                    }

                }
                else if (age < 10)
                {
                    Console.WriteLine("your are kid,\nDo you want to print table \n");

                    Console.WriteLine("yes or no");
                    string t = Console.ReadLine();
                    if (t == "yes")
                    {
                        int a;
                        Console.WriteLine("Enter a number to print its table");
                        a = int.Parse(Console.ReadLine());

                        // using for loop 

                        for (int i = 1; i <= 10; i++)
                        {

                            Console.WriteLine(a + " X " + i + " = "+ (a*i));

                        }

                    }


                }
                else
                {
                    Console.WriteLine(" hello men| do you want to watch movies. yes/no");
                   
                    string movie;
                    movie = Console.ReadLine().ToLower();
                    if (movie == "yes")
                    {
                        movie = Console.ReadLine();
                        Console.WriteLine(" Enter duration in hours 1 to 3  ");
                        int x = int.Parse(Console.ReadLine());
                        
                        // using while loop

                        while (x <= 3)
                        {
                            x = x + 1;
                            Console.WriteLine(".");

                        }
                        Console.WriteLine("you have watched movie");

                    }
                   

                }
                Console.WriteLine("Enter yes to continue and no to exit");
                o = Console.ReadLine().ToLower();

            }

            while (o == "yes");



          }
    }
}
