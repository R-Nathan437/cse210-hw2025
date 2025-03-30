public class Customer
{
    private string _customerName;
    public string customerName
    {
        get{return _customerName;}
        set{_customerName = value;}
    }
    private Address _address;
    public Address address
    {
        get{return _address;}
        set{_address = value;}
    }
    public Customer(string customerName, Address address)
    {
        _customerName  = customerName;
        _address = address;
    }
    public bool IsUSA()
    {
       return address.IsUSA();
    }
} 