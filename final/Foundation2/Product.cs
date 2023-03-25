using System;

class Product
{
    private string _productName;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string aName, int aID, double aPrice, int aQuantity)
    {
        _productName = aName;
        _id = aID;
        _price = aPrice;
        _quantity = aQuantity;
    }
    public double GetProductPrice()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _productName;
    }
    public int GetId()
    {
        return _id;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetSinglePrice()
    {
        return _price;
    }

}