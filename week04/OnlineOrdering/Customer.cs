using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address) //todo cliente tem nome e endereco. cconstrutor
    {
        _name = name;
        _address = address;
    }

    public string GetName() //getter. acesso controlado dos dados
    {
        return _name;
    }

    public bool LivesInUSA() //aqui ele pergunta ao endereco se ele e dos states
    {
        return _address.IsInUSA();
    }

    public Address GetAddress() //getter. acesso controlado dos dados
    {
        return _address;
    }
}