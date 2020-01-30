using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContainsCraftWebsite.Models;
using ContainsCraftWebsite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContainsCraftWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public JsonFileProductsService ProductService { get; }
        public ProductsController(JsonFileProductsService productService)
        {
            ProductService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

        [Route("rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string ProductId, 
            [FromQuery] int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}