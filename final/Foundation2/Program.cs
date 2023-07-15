using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Herriman", "3321 W Devotion Dr", "Utah", "USA");
        Customer customer1 = new Customer("Chuck Bartowski", address1);
        Products product1 = new Products("Chapstick", 457392, 6, 8.99);
        Products product2 = new Products("Dr. Pepper", 420697, 12, 19.99);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.GetPackingLabel();
        order1.GetShippingLabel();
        string price = order1.CalculateShippingCost();
        Console.WriteLine(price);
        Console.WriteLine("");
        Address address2 = new Address("Bessano", "4532 pickle st", "Alberta", "Canada");
        Customer customer2 = new Customer("Duncan Follis", address2);
        Products cheese = new Products("String", 888888, 8, 8.88);
        Products hardDrive = new Products("Harddrive", 902653, 2, 150.99);
        Products ketchupChips = new Products("Ketchup crisps", 652937, 1, 12.99);
        Order order2 = new Order(customer2);
        order2.AddProduct(cheese);
        order2.AddProduct(hardDrive);
        order2.AddProduct(ketchupChips);
        order2.GetPackingLabel();
        order2.GetShippingLabel();
        string price2 = order2.CalculateShippingCost();
        Console.WriteLine(price2);
    }
}