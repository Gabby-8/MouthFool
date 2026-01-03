using Backend.Models;

namespace Backend.Services.Interfaces;

public interface IProductService
{
    IEnumerable<Products> GetAll();
    Products? GetProductsById(int id);
}