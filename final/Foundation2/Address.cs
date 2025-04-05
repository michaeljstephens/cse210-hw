class Address
{
    private string country;


    public Address(string country)
    {
        this.country = country;
    }


    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }
}