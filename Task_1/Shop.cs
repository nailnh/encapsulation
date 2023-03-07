internal class Shop
{
    private string _name;
    public Product[] products;

    

    public string Name
    {
        get { return _name; }
        set
        {
            if (!string.IsNullOrEmpty(value.Trim(' ')) && value.Length > 1 && value.Length < 50)
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("Name is not invalid!");
            }
        }
    }
    public Shop()
    {
        products = new Product[0];
    }

    public void CreateProduct()
    {
        Console.WriteLine("Product name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Product price: ");
        double price = double.Parse(Console.ReadLine());

        Product product = new Product
        {
            Name = name,
            Price = price
        };
        Array.Resize(ref products, products.Length+1);
        products[products.Length-1] = product;
    }

    public void ShowProducts()
    {
        foreach (Product product in products)
        {
            Console.WriteLine($"Name of the Product: {product.Name}\nPrice of the Product: {product.Price}");
        }
    }
}





