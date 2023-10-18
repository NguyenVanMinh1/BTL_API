using BLL.Iterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TONGXUANTU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlideController : ControllerBase
    {
        private ISlideBus _ProductBus;
        public SlideController(ISlideBus productBus)
        {
            _ProductBus = productBus;
        }
        [HttpGet]
        [Route("GetAllSlide")]
        public IActionResult GetAllSlide()
        {
            return Ok(_ProductBus.GetAllSlide());
        }
    }
}
