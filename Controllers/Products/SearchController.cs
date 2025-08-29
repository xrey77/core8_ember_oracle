using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using core8_ember_oracle.Services;
using core8_ember_oracle.Models.dto;
using core8_ember_oracle.Helpers;
using core8_ember_oracle.Models;

namespace core8_ember_oracle.Controllers.Products
{
    [ApiExplorerSettings(GroupName = "Search Product Description")]
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase {

        private IProductService _productService;

        private IMapper _mapper;
        private readonly IConfiguration _configuration;  

        private readonly IWebHostEnvironment _env;

        private readonly ILogger<SearchController> _logger;

        public SearchController(
            IConfiguration configuration,
            IWebHostEnvironment env,
            IProductService productService,
            IMapper mapper,
            ILogger<SearchController> logger
            )
        {
            _configuration = configuration;  
            _productService = productService;
            _mapper = mapper;
            _logger = logger;
            _env = env;        
        }  

        [HttpGet("/api/searchproducts/{page}/{key}")]
        public async Task<IActionResult> SearchProducts(int page, string key) {
            try {                
                var totalpage = await _productService.TotPageSearch(page, key);

                var products = await _productService.SearchAll(page,key);
                if (products.Count() > 0) {
                    var model = _mapper.Map<IList<ProductModel>>(products);
                    return Ok(new {totpage = totalpage, page = page, products=model, message=""});
                } else {
                    return BadRequest(new {statuscode=400, message="No Data found."});
                }
            } catch(AppException ex) {
               return BadRequest(new {statuscode = 400, message = ex.Message});
            }
        }
    }    
}