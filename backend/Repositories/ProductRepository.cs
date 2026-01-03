using Backend.Models;
using Backend.Repositories.Interfaces;

namespace Backend.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly List<Products> products = new()
    {
        new Products
        {
             Id = 1,
            Name = "Choco-Almond Croffle",
            Description = "A crispy, buttery croissant-waffle topped with whipped cream and rich chocolate, creamy drizzle, and crunchy toasted almonds.",
            Price = 145,
            ImageUrl = "http://localhost:5125/images/Choco-Almond.jpg"
        },
        new Products
        {
            Id = 2,
            Name = "Biscoff Croffle",
            Description = "A golden, flaky croissant-waffle layered with whipped cream and finished with a rich, spiced Biscoff drizzle for a warm caramel flavor.",
            Price = 150,
            ImageUrl = "http://localhost:5125/images/Biscoff.jpg"
        },
        new Products
        {
            Id = 3,
            Name = "Cookies 'N Cream Croffle",
            Description = "A warm croissant-waffle topped with whipped cream, crushed chocolate biscuits, and a drizzle of rich chocolate sauce",
            Price = 145,
            ImageUrl = "http://localhost:5125/images/CookiesnCream.jpg"
        },
        new Products
        {
            Id = 4,
            Name = "Pistachio",
            Description = "A toasty croissant-waffle topped with whipped cream, and a drizzle of rich",
            Price = 150,
            ImageUrl = "http://localhost:5125/images/Pistachio.jpg"
        }
    };

    public IEnumerable<Products> GetProducts()
    {
        return products;
    }

    public Products? GetById(int id)
    {
        return products.FirstOrDefault(p => p.Id == id);
    } 
}