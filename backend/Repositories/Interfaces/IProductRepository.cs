using Backend.Models;

namespace Backend.Repositories.Interfaces;

public interface IProductRepository
{
    IEnumerable<Products> GetProducts();
    Products? GetById(int id);
}