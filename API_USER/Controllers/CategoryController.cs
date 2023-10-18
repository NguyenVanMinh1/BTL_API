using BLL.Iterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TONGXUANTU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryBus _categoryBus;
        public CategoryController (ICategoryBus categoryBus)
        {
            _categoryBus = categoryBus;
        }
        [HttpGet]
        [Route("GetAllCategory")]
        public IActionResult GetAllCategory()
        {
            return Ok(_categoryBus.GetAll());
        }
        [HttpGet]
        [Route("GetProductByCategory/{CategoryID}")]
        public IActionResult GetProductByCategory(int CategoryID)
        {
            return Ok(_categoryBus.GetProductByCategory(CategoryID));
        }
    }
}
