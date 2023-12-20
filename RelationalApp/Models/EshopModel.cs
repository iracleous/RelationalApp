namespace RelationalApp.Models;

/**
 * 
 Customer
   Id, Name, Email
Product
   Id, Name, Price
Basket
   Id, DateTime, Customer, List<Product>
 */

public class Customer {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public virtual List<ProductBasket> ProductBaskets { get; set; }
}

public class Basket
{
    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public virtual Customer? Customer { get; set; }  
    public virtual List<ProductBasket> ProductBaskets { get; set;}
}


public class ProductBasket
{

    public int Id { get; set; }
    public int Quantity { get; set; }
    public virtual Basket Basket { get; set; }
    public virtual Product Product { get; set; }

}