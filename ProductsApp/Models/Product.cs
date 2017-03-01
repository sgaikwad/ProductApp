
public class Rootobject
{
    public Productdetails productDetails { get; set; }
}

public class Productdetails
{
    public Product[] products { get; set; }
}

public class Product
{
    public string material { get; set; }
    public string description { get; set; }
}
