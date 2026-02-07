using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer) //construtor. inicia a lista vazia
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product) //aqui vai controlar como os pedidos entram
    {
        _products.Add(product);
    }

    public double CalculateTotalCost() //vai calcular o custo total. tudo fica dentro dessa classe
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return total + shippingCost;
    }

    public string GetPackingLabel() //lista o nome e id de cada coisas
    {
        string label = "Packing Label:\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return label;
    }

    public string GetShippingLabel() //mostra as info
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
