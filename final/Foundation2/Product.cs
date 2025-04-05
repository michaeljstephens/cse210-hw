class Product
{
    public string name;
    public int id;
    public double price;
    public int quantity;

    public Product(string name, int id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }


    public double TotalCost()
    {
        return price * quantity;
    }
}