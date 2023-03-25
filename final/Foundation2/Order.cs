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
    public double GetOrderTotal()
    {
        return GetOrderTotal() + GetShippingCost();
    }
    public string GetShippingLabel()
    {
        return $"{_currentCustomer.GetName()}\n{_currentCustomer.GetAddress()}";
    }
    public void GetPackingLabel()
    {
        Console.WriteLine("Product    ID      Quantity    Price");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetName()}, {product.GetId()}, {product.GetQuantity()}, {product.GetSinglePrice()}");
        }
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
}