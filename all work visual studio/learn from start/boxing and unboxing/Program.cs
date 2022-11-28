// See https://aka.ms/new-console-template for more information

/*
 * boxing is converting value type to refrence type.
 * this is implicit conversion ans compiler done itself
 */
int a = 12; // this is value type 
object obj = a+2; //this is convertsion from value type to refrence type,  object is parent class of all class in c sharp

Console.WriteLine(obj);

// converting from ref to value type is unboxing 

object ob = 23;
Console.WriteLine(" obj = "+ ob);

int c = (int)ob;
Console.WriteLine("value after converting into int is "+c);
