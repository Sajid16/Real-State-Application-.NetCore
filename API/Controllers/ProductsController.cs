using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using API.Entities;
using API.Data;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("api/Products")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _dbContext;
        public ProductsController(StoreContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            var products = _dbContext.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = _dbContext.Products.Find(id);
            return Ok(product);
        }
    }
}