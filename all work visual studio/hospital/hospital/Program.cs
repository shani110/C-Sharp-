// See https://aka.ms/new-console-template for more information
using hospital.Module;

Console.WriteLine("Hello, World!");
using (var context = new dataContext())
{
    Doctor obj = new Doctor();
    obj.id = 1;
    obj.name = "hayat";
    obj.hName = "icus";
    obj.age = 43; 
    
    context.doctors.Add(obj);
    context.SaveChanges();

}