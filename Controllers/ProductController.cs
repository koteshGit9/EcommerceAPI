using EcommerceAPI.Entitys;
using EcommerceAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct productService;
        public ProductController()
        {
            productService = new ProductService();
        }
        [HttpGet, Route("GetAllProducts")]
        public IActionResult GetAll()
        {
            try
            {
                List<Product> products = productService.GetProduct();
                return StatusCode(200, products);  //json format
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }

        }
        [HttpGet, Route("GetproductbyId/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Product products = productService.GetProductById(id);
               
                    return StatusCode(200, products);
                

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }



        }


        [HttpPost, Route("AddProducts")]
        public IActionResult Add(Product Product)
        {
            try
            {
                productService.AddProduct(Product);
                return StatusCode(200, Product);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }


        [HttpPut, Route("EditProduct")]
        public IActionResult Edit(Product Product)
        {

            try
            {
                productService.UpdateProduct(Product);
                return StatusCode(200, Product);

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }

        }
        [HttpDelete, Route("DeleteProduct/{productId}")]
        public IActionResult Delete(int productId) 
        {

            try
            {
                productService.DeleteProduct(productId);
                return StatusCode(200, new JsonResult($"product with Id {productId} is Deleted"));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

    }
}
