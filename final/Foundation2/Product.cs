using System.Security.Cryptography.X509Certificates;

public class Product
{
    private string _name;
    public string name
    {
        get{return _name;}
        set{_name = value;}
    }
    private string _productID;
    public string productID
    {
        get{return _productID;}
        set{_productID = value;}
    }
    private double _price;
    public double price
    {
        get{return _price;}
        set{_price = value;}
    }
    private int _quantity;
    public int quantity
    {
        get{return _quantity;}
        set{_quantity = value;}
    }
    public Product(string name, string productID, double price)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = 0;
    }
    public double TotalCost()
    {
        return price * quantity;    
    }

}