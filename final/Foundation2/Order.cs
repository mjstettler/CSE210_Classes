using System;

class Order 
{
    private List<Product> _products;
    private Customer _currentCustomer;
    
    public Order()
    {
        _products = new List<Product>();
    }
    public double GetProductTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetProductPrice();
        }
        return total;
    }
    public void GetOrderTotal()
    {
        Console.WriteLine($"Order total: ${GetProductTotal() + GetShippingCost()}\n");
    }
    public void GetShippingLabel()
    {
        Console.WriteLine("Shipping Label:\n");
        Console.WriteLine($"{_currentCustomer.GetName()}\n{_currentCustomer.GetAddress()}\n");
    }
    public void GetPackingLabel()
    {
        Console.WriteLine("Packing Label");
        Console.WriteLine("\nProducts:\n");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetName()},  PLU# {product.GetId()}");
        }
        Console.WriteLine();
    }

    public double GetShippingCost()
    {
        if (_currentCustomer.GetCountry() == true)
        {
            return 5;
        }
        else
            return 35;
    }

    public void AddProduct(string aName, int aID, double aPrice, int aQuantity)
    {
        _products.Add(new Product(aName, aID, aPrice, aQuantity));
    }
    
    public void SetCustomerName(string aName)
    {
        _currentCustomer = new Customer(aName);
    }

    public void SetCustomerAddress(string aStreet, string aCity, string aStateProvidence, string aCountry)
    {
        _currentCustomer.SetAddress(aStreet,aCity,aStateProvidence,aCountry);
    }
}
