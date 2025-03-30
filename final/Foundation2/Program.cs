using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("345 Circle Cr", "Metropolis", "Idaho", "USA");
        Address address2 = new Address("1234 Street St", "Toon town", "PA", "CA");
        Customer customer1 = new Customer("Namor", address1);
        Customer customer2 = new Customer("Nickol", address2);
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Product tape = new Product("Tape", "10001", 2.03);
        Product mug = new Product("Mug", "10002", 3.51);
        Product mouse = new Product("Mouse", "10003", 11.89);
        order1.AddProduct(tape);
        order1.AddProduct(mouse);
        order1.AddProduct(mug);
        order1.AddProduct(tape);
        order1.DisplayRecipt();
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        order1.ClearCart();
        order2.AddProduct(tape);
        order2.AddProduct(mouse);
        order2.AddProduct(mug);
        order2.AddProduct(mug);
        order2.AddProduct(mug);
        order2.AddProduct(mug);
        order2.AddProduct(mug);
        order2.DisplayRecipt();
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
    }       
}