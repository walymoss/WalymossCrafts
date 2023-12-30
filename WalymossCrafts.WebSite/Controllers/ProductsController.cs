using Microsoft.AspNetCore.Mvc;
using WalymossCrafts.WebSite.Models;
using WalymossCrafts.WebSite.Services;

namespace WalymossCrafts.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
                this.ProductService = productService;
        }

        public JsonFileProductService ProductService { get; set; }

        [HttpGet]
        public IEnumerable<Product> Get() 
        { 
            return ProductService.GetProducts();
        }
    }
}
