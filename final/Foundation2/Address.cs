using System;

class Address
{
    string _streetAddress;
    string _city;
    string _stateProv;
    string _country;

    public Address(string aStreet, string aCity, string aStateProvidence, string aCountry)
    {
        _streetAddress = aStreet;
        _city = aCity;
        _stateProv = aStateProvidence;
        _country = aCountry;
    }

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

    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProv}, {_country}";
    }

}