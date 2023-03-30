using System;

class Address
{
    private string _street;
    private string _city;
    private string _stateProvidence;
    private string _country;

    public Address(string aStreet, string aCity, string aStateProvidence, string aCountry)
    {
        _street = aStreet;
        _city = aCity;
        _stateProvidence = aStateProvidence;
        _country = aCountry;
    }

    public string DisplayAddress()
    {
        return $"\n{_street}\n{_city}, {_stateProvidence}, {_country}";
    }

}