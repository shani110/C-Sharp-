using System;

namespace animals
{

    class animal 
    {
        string name;
        int age;
        string color;

        public void setAnimal(string name, int age, string color)
        
        {
            this.name = name;
            this.age = age;
            this.color =color;

        
        }
        public void getAnimal()
        {

            Console.WriteLine("animal name is "+this.name);
            Console.WriteLine("animal age is "+this.age);
            Console.WriteLine("animal color is "+this.color);

        }
        public static string category = "animal";

        public static void showCategory() 
        {
            Console.WriteLine(this.category);
        
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            animal bird = new animal();
            bird.setAnimal("piegon", 2, "brown");
            bird.getAnimal();
            Console.WriteLine("------------------------");

            animal dog = new animal();
            dog.setAnimal("German shepard", 3, "black and white");
            dog.getAnimal();
            animal.showCategory() ;



        }
    }
}
