using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = new List<Products>
        {
            new Products
            {
                Id = 1,
                Name = "",
                Description = "",
                Price = 0,
                ImageUrl = ""
            },

        };

        return Ok(products);
    }
}