using System.Reflection.Emit;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Customer customer
    {
        get{return _customer;}
        set{_customer = value;}
    }
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void ClearCart()
    {
        foreach (Product product in _products)
        {
            product.quantity = 0;
        }
        _products.Clear();
    }
    public void AddProduct(Product product)
    {
        if (product.quantity > 0)
            {
               foreach (Product p in _products)
                {
                    if (p.productID == product.productID)
                    {
                        p.quantity++;
                    }
                }
            }
        else
        {
            product.quantity++;
            _products.Add(product);
        }        
    }
    public double CalculateTotal()
    {
        double subtotal = 0;
        foreach (Product product in _products)
        {
            subtotal += product.TotalCost();
        }
        if  (subtotal > 0)
        {
            if (customer.IsUSA())
            {
                subtotal += 5;
            }   
            else
            {
                subtotal += 35;
            }
        }
        return Math.Round(subtotal, 2);
    }
    public string PackingLabel()
    {
        string packingLabel = "PRODUCT          ID\n";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.name}|{product.quantity}            {product.productID}\n";
        }
        return packingLabel;
    }
    public string ShippingLabel()
    {
        return $"SHIPPING LABEL\n---------------------------------\n\n{customer.customerName}\n{customer.address.fullAddress()}";
    }
    public void DisplayRecipt()
    {
        Console.WriteLine($"{customer.customerName.ToUpper()}'S ORDER\n---------------------------------");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.name}||  {product.price}|[{product.quantity}]");
        }
        if (CalculateTotal() > 0)
        {
            if (customer.IsUSA())
            {
                Console.WriteLine("\nDomestic $5 shipping\n");
            }
            else
            {
                Console.WriteLine("\nForeign $35 shipping\n");
            }
            
        }
        Console.WriteLine($"${CalculateTotal()}\n---------------------------------");
    }

}