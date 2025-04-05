class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }


    public void AddProduct(Product product)
    {
        products.Add(product);
    }


    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.TotalCost();
        }
        total += customer.IsInUSA() ? 5 : 35; 
        return total;
    }


    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product product in products)
        {
            Console.WriteLine(product.name + " (ID: " + product.id + ")");
        }
        Console.WriteLine();
    }


    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label: " + customer.name);
        Console.WriteLine();
    }
}