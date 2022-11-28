// See https://aka.ms/new-console-template for more information


using non_generic_collections.Arraylist;
using System.Collections;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        //ArrayList obj = new ArrayList();
        //obj.Add(2);
        //obj.Add(3);
        //obj.Add("shani");
        //obj.Add(23.43);
        //obj.Add(6);
        //obj.Add(7);
        //obj.Add(8);


        //foreach (var item in obj)
        //{
        //    Console.Write(item + " ");

        //}

        // printing object type data from array list . 

        //work a = new work(1, "muhammad isa", 23);
        //work b = new work(2, "alam", 24);

        //work[] arr =
        //    { 
        //    a,b,
        //    new work(3,"sheraz",21),
        //    new work(4,"shabih",25),
        //    new work(5,"rukhsi",24)
        //   };

        // working with hashtable 

        Hashtable ht = new Hashtable();
        ht.Add("name", "shani");
        ht.Add("id", 12);
        ht.Add("salary", 232323);



        foreach (var item in ht)
        {
            Console.WriteLine(item);
        }
                

    }
}