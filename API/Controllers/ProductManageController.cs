using BLL.BusUser;
using BLL.Iterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.PublicModel;
using Model.PublicModel;

namespace TONGXUANTU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductManageController : ControllerBase
    {
        private IProductManageBus _BrandBus;
        public ProductManageController(IProductManageBus brandBus)
        {
            _BrandBus = brandBus;
        }
        [Route("AddSanPham")]
        [HttpPost]
        public ProductModel CreateProduct([FromBody] ProductModel model)
        {
            _BrandBus.AddProduct(model);
            return model;
        }
        [Route("UpdateSanPham")]
        [HttpPost]
        public ProductModel UpdateProduct([FromBody] ProductModel model)
        {
            _BrandBus.UpdateProduct(model);
            return model;
        }
     
       
       
            [Route("DeleteProduct/{id}")]
            [HttpDelete]
            public IActionResult DeleteProduct(int id)
            {
                try
                {
                    var result = _BrandBus.DeleteProduct(id);
                    return Ok("Xóa thành công");
                }
                catch (DbUpdateException ex)
                {
                    // Handle foreign key constraint violation error
                    return BadRequest("Khóa ngoại không hợp lệ");
                }
                catch (Exception ex)
                {
                    // Handle other errors
                    return StatusCode(500, "Đã xảy ra lỗi không mong muốn");
                }
            }

        

        [HttpGet]
        [Route("GetAllProduct")]
        public IActionResult GetAllProduct()
        {
            return Ok(_BrandBus.GetAllProduct());
        }
        [HttpGet]
        [Route("GetProductById/{id}")]
        public IActionResult getProductById(int id)
        {
            return Ok(_BrandBus.GetProductById(id));
        }
        [HttpGet]
        [Route("GetProductByName/{name}")]
        public IActionResult GetProductByName(string name)
        {
            return Ok(_BrandBus.SearchProductByName(name));
        }
    }
}
