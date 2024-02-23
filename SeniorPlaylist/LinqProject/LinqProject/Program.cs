List<Category> categories = new List<Category>
{
    new Category{CategorytId= 1, CategorytName="Bilgisayar"},
    new Category{CategorytId= 2, CategorytName="Telefon"}
};

List<Product> products = new List<Product>
{
    new Product{ProductId= 1, CategorytId= 1 , ProductName="Laptop", QuantityPerUnit ="Monster", UnitPrice = 20000, UnitsInStock=50},
    new Product{ProductId= 2, CategorytId= 2 , ProductName="Dokunmatik Telefon", QuantityPerUnit ="Xiaomi", UnitPrice = 10000, UnitsInStock=330},
    new Product{ProductId= 3, CategorytId= 2 , ProductName="Dokunmatik Telefon", QuantityPerUnit ="Samsung", UnitPrice = 12000, UnitsInStock=200},
};

//var result = products.Where(p=>p.UnitPrice>5000 && p.UnitsInStock>50);
//foreach (var product in result)
//{
//    Console.WriteLine(product.QuantityPerUnit);
//}

GetProductLinq(products);

static List<Product> GetProductLinq(List<Product> products)
{
    var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 50).ToList();
    return result;
}

class Product
{
    public int ProductId { get; set; }
    public int CategorytId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}
class Category
{
    public int CategorytId { get; set; }
    public string CategorytName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}
