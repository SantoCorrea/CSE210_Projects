using System.Security;

public class Product
{
    private string _name;
    private string _productID;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productID, decimal price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    
    public string GetName()
    {
        return _name;
    }
    
    public String GetProductID()
    {
        return _productID;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }
}