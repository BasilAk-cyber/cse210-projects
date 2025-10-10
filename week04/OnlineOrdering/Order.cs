using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;
        double shippingfee = 5.0;

        foreach (Product product in _products)
        {
            total+= product.GetTotalCost();
        }

        if (!_customer.IsInUS())
        {
            shippingfee = 35.0;
        }
        return total + shippingfee;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} ({product.GetProductId()})\n";
        }
        return label;
    }
    
    public string ShippingLabel()
    {
        return _customer.ToString();
    }
    
}