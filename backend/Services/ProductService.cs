using Backend.Models;
using Backend.Repositories.Interfaces;
using Backend.Services.Interfaces;

namespace Backend.Services;

public class ProductService(IProductRepository repo) : IProductService
{
    private readonly IProductRepository _repo = repo;

    public IEnumerable<Products> GetAll()
    {
        return _repo.GetProducts();
    }

    public Products? GetProductsById(int id)
    {
        return _repo.GetById(id);
    }
}