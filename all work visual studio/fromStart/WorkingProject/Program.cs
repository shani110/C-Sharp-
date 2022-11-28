// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using WorkingProject.context;
using WorkingProject.module;

Console.WriteLine("code is working");

//using (var context = new DataContext())
//{
//Product p1 = new Product();
//p1.productName = "laptop";
//p1.price = 45900;o

//p1.productName = "computers";
//p1.price = 5000;

//Product p2 = new Product();
////p2.price = 42222;
////p2.productName = "tablet";
//p2.productName = "head phones";
//p2.price = 2000;
//context.products.Add(p1);
//context.products.Add(p2);
//context.SaveChanges(); 

//adding data in customer 

//Customer customer = new Customer();
//customer.firstName = "shabi";
//customer.lastName = " hussain";
//customer.email = "sh@gmail.com";

//Customer customer1 = new Customer();
//customer1.firstName = "alam";
//customer1.lastName = " sher";
//customer1.email = "as@gmail.com";
//context.customers.Add(customer); 
//context.customers.Add(customer1);
// context.SaveChanges();

//Order order = new Order();
//order.orderAmount = 200;

using (var context = new DataContext()) 
{


    var prod = new Product()
    {
        productId = 2,
        productName = "boofers "
       
    };
    context.Update(prod);
    await context.SaveChangesAsync();


}

    

    
   
   



