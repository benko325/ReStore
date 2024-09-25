using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class ProductsController(StoreContext context) : BaseApiController
{
    private readonly StoreContext context = context;

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        return await context.Products.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        var product = await context.Products.FindAsync(id);
        return product == null ? NotFound() : Ok(product);
    }
}
