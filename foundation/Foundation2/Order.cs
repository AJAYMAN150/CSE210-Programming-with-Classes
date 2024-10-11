using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = products.Sum(product => product.GetTotalCost());
        total += customer.IsInUSA() ? 5 : 35; // $5 shipping for USA, $35 for outside USA
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder("Packing Label:\n");
        foreach (Product product in products)
        {
            packingLabel.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress()}";
    }
}
