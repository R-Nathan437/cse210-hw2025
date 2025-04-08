using System.Formats.Asn1;

public class Address
{
    private string _streetAddress;
    public string streetAddress
    {
        get{return _streetAddress;}
        set{_streetAddress = value;}
    }
    private string _city;
    public string city
    {
        get{return _city;}
        set{_city = value;}
    }
    private string _stateOrProvince;
    public string stateOrProvince
    {
        get{return _stateOrProvince;}
        set{_stateOrProvince = value;}
    }


    public Address(string streetAddress, string city, string stateOrProvince)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
    }

    public string FullAddress()
    {
        return $"{streetAddress}\n{city}, {stateOrProvince}\n";
    }
    
}

