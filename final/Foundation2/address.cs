class Address
{
    public string StreetAddress;
    public string City;
    public string StateOrProvince;
    public string Country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.ToUpper() == "USA";
    }

    public string FullAddress()
    {
        return $"{StreetAddress}\n{City}, {StateOrProvince}\n{Country}";
    }
}