using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string StreetAddress, string City, string State, string Country)
    {
        _streetAddress = StreetAddress;
        _city = City;
        _state = State;
        _country = Country;
    }

    public void SetStreetAddress(string StreetAddress)
    {
        _streetAddress = StreetAddress;
    }

    public void SetCity(string City)
    {
        _city = City;
    }

    public void SetState(string State)
    {
        _state = State;
    }

    public void SetCountry(string Country)
    {
        _country = Country;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }

    public bool LivesInUS()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states" || _country.ToLower() == "us";
    }



    public override string ToString()
    {
        return $"{_streetAddress}\n{_city},{_state}\n{_country}";
    }
}