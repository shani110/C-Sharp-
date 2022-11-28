 using System;
using System.Collections.Generic;
namespace ConsoleApp3
{
    
    

    class Program
    {

  
   
   
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(0, "ali");
            dic.Add(1, "karamat");

            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }
            
            
        
       
        }
    }
}

