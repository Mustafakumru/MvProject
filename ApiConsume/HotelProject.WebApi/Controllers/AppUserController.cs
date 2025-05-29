using BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUsersServices _appUsersServices;

        public AppUserController(IAppUsersServices appUsersServices)
        {
            _appUsersServices = appUsersServices;
        }

        //[HttpGet]
        //public IActionResult UserListWithWorkLocation()
        //{
        //    var values = _appUsersServices.TUserListWithWorkLocation();
        //    return Ok(values);
        //}
        [HttpGet ("AppUserList")]
        public IActionResult AppUserList()
        {
            var values=_appUsersServices.TGetList();
            return Ok(values);
        }
    }
}
