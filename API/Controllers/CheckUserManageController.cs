using BLL.BusUser;
using BLL.Iterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TONGXUANTU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckUserManageController : ControllerBase
    {
        private ICheckUserManageBus _checkusermanagebus;
        public CheckUserManageController(ICheckUserManageBus brandBus)
        {
            _checkusermanagebus = brandBus;
        }
        [Route("Check_UserName/{username}_PassWord/{password}")]
        [HttpGet]
        public IActionResult CheckUser(string username, string password)
        {
          return Ok(  _checkusermanagebus.CheckUser(username, password));
            
        }
    }
}
