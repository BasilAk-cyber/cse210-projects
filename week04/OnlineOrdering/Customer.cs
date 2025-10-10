using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string Name, Address address)
    {
        _name = Name;
        _address = address;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool IsInUS()
    {
        return _address.LivesInUS();
    }

    public override string ToString()
    {
        return $"{_name}\n{_address.ToString()}";
    }
}