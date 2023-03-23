using System;

class Address
{
    string _streetAddress;
    string _city;
    string _stateProv;
    string _country;

    public bool GetCountry()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}