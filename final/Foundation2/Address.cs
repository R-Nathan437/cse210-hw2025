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
    private string _country;
    public string country
    {
        get{return _country;}
        set{_country = value;}
    }
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string fullAddress()
    {
        return $"{streetAddress}\n{city}, {stateOrProvince}\n{country}";
    }
    public bool IsUSA()
    {
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
       
    }
}

