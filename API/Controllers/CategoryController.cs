using BLL.BusUser;
using BLL.Iterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.PublicModel;

namespace TONGXUANTU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryManageBus _checkusermanagebus;
        public CategoryController(ICategoryManageBus brandBus)
        {
            _checkusermanagebus = brandBus;
        }
        [HttpGet]
        [Route("GetAllCategory")]
        public IActionResult GetAllCategory()
        {
            return Ok(_checkusermanagebus.GetAllCategory());
        }
        [Route("AddCategory")]
        [HttpPost]
        public CategoryModel CreateCATEGORY([FromBody] CategoryModel model)
        {
           _checkusermanagebus.AddSanPham(model);
            return model;
        }
        [Route("UpdateCategory")]
        [HttpPost]
        public CategoryModel UpdateCate([FromBody] CategoryModel model)
        {
            _checkusermanagebus.UpdateSanPham(model);
            return model;
        }
        [Route("DeleteCategory/{id}")]
        [HttpDelete]
        public IActionResult DeleteCate(int id)
        {
            try
            {
                var result = _checkusermanagebus.DeleteSanpham(id);
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
    }
}
