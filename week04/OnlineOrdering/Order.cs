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

    private decimal GetShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5m;
        }
        else
        {
            return 35m;
        }
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        return total + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductID()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }

}