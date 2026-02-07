using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country) // garante que esteja completo. construtor
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA() //aqui esta vendo se e no states ou nao. vai retornar true se for usa
    {
        return _country.ToUpper() == "USA";
    }

    public string GetFullAddress()  //junta toda parte do endereco
    {
        return $"{_street}, {_city}, {_state} - {_country}";
    }

}