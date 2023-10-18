using BLL.Iterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TONGXUANTU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private IBrandManageBus _checkusermanagebus;
        public BrandController(IBrandManageBus brandBus)
        {
            _checkusermanagebus = brandBus;
        }
        [HttpGet]
        [Route("GetAllBrands")]
        public IActionResult GetAllBrand()
        {
            return Ok(_checkusermanagebus.GetAllBrand());
        }
    }
}
