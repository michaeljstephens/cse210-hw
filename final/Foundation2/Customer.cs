class Customer
{
    public string name;
    private Address address;

    public Customer(string name, string country)
    {
        this.name = name;
        address = new Address(country);
    }


    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}