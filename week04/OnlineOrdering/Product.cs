using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity) //cria o produto com os dados necessarios. construtor
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

     public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetTotalCost() //calcular internamente
    {
        return _price * _quantity;
    }
}