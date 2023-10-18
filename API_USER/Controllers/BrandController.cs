using BLL.BusUser;
using BLL.Iterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TONGXUANTU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private IBrandBus _BrandBus;
        public BrandController(IBrandBus brandBus)
        {
            _BrandBus = brandBus;
        }
        [HttpGet]
        [Route("GetAllBrand")]
        public IActionResult GetAllBrand()
        {
            return Ok(_BrandBus.GetAllBrand());
        }
    }
}
