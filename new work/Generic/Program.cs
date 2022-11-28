using System;

namespace Generic
{
  


    class Program
    {
        public static void show<G>(G[] a) 
        {

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            
            
            }
        
        
        }

        static void Main(string[] args)
        {
            Console.WriteLine("how many items do you have");
            int a = int.Parse(Console.ReadLine());
            string[] arr = new string[a];
            Console.WriteLine("Enter names of items ");
            for (int i = 0; i < arr.Length; i++) 
            {
                string name = Console.ReadLine();
                arr[i] = name;
            
            }
            Console.WriteLine(" you have following");
            Program.show(arr);

            Console.WriteLine("----------------------------");
            Console.WriteLine("how many students are there in your class  ");
            int b = int.Parse(Console.ReadLine());
            int[] arr1 = new int[a];
            Console.WriteLine("Enter roll no of studendt ");
            for (int j = 0;j < arr1.Length; j++)
            {
                int rolNo =int.Parse( Console.ReadLine());
                arr1[j] = rolNo;

            }
            Console.WriteLine(" you have following");
            Program.show(arr1);
        }
    }
}
