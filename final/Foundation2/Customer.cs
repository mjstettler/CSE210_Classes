using System;

class Customer
{
    private string _name;
    private Address _customerAddress;

    public Customer(string aName)
    {
        _name = aName;
    }

    public void SetAddress(string aStreet, string aCity, string aStateProvidence, string aCountry)
    {
        _customerAddress = new Address(aStreet, aCity, aStateProvidence, aCountry);
    }

    public bool GetCountry()
    {
        return _customerAddress.GetCountry();
    }
    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _customerAddress.GetAddress();
    }

}

