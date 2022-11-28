// See https://aka.ms/new-console-template for more information
using records.com;
using System.Net.Http.Headers;

//working with records


Record obj = new Record("isa", 23);
Record ob  = new Record("shbii", 24);
Record o   = new Record("isa", 24);


//Console.WriteLine(obj);
//Console.WriteLine("ob value is "+ob);
//Console.WriteLine("values in o are " + o);

//Console.WriteLine("obj and ob are equal :" +Equals(obj,ob));
//Console.WriteLine("obj and o are equal : " + Equals(obj, o));

//== 
//Console.WriteLine(obj==ob);


// getting hascode of recored

Console.WriteLine("hash code is " + obj.GetHashCode());
//Console.WriteLine("hash code is " + ob.GetHashCode());
//Console.WriteLine("hash code is " + o.GetHashCode());

var (a, b) = obj;
Console.WriteLine("name is {0} and age is {1}",a,b);

// methods in records 

//Record1 t = new Record1("muhamamd ", "Isa");
//t.sayhello();

// data 


