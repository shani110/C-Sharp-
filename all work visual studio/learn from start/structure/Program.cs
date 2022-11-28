// See https://aka.ms/new-console-template for more information

using structues.com;
// this will add two int type numbers 

myStructure obj = new myStructure();


// this will show structure is value type

obj.a = 12;
obj.b = 13;
obj.add();


// below program is to show structure is value type

obj.age = 12;

var obj1 = obj;
obj1.age = 13;
Console.WriteLine("new obj1 value");
Console.WriteLine(obj1.age);

Console.WriteLine("old obj value ");
Console.WriteLine(obj.age);