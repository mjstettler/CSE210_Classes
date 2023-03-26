using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        Order order2 = new Order();
        order1.SetCustomerName("Mike Stettler");
        order1.SetCustomerAddress("75 Happiness way","Enoch","Utah", "USA");

        order2.SetCustomerName("Ivy Chapman");
        order2.SetCustomerAddress("1010 Enlightenment drive","York","North Yorkshire", "United Kingdom");

        order1.AddProduct("Lettuce",4640, 1.88, 2);
        order1.AddProduct("Beef Steak Tomato", 3061, 1.10, 2);
        order1.AddProduct("Hardwood Smoked Bacon", 0001111096827, 3.99, 1);

        order2.AddProduct("Lettuce",4640, 1.88, 2);
        order2.AddProduct("Beef Steak Tomato", 3061, 1.10, 2);
        order2.AddProduct("Hardwood Smoked Bacon", 0001111096827, 3.99, 1);

        order1.GetPackingLabel();
        order1.GetShippingLabel();
        order1.GetOrderTotal();
        Console.WriteLine("--------------------------------------------------\n");
        order2.GetPackingLabel();
        order2.GetShippingLabel();
        order2.GetOrderTotal();

    }
}