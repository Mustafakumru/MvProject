using BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashbordWidgetController : ControllerBase
    {
        private readonly IStaffServices _staffServices;
        private readonly IBookingService _bookingService;
        private readonly IGuestService _guestService;
        private readonly IAppUsersServices _appUsersServices;
        public DashbordWidgetController(IStaffServices staffServices,IBookingService bookingService,IGuestService guestService,IAppUsersServices appUsersServices)
        {
            _appUsersServices = appUsersServices;
            _staffServices = staffServices;
            _bookingService = bookingService;
            _guestService = guestService;
        }
      
        [HttpGet ("StaffCount")]
        public IActionResult StaffCount()
        {
            var value=_staffServices.TGetStaffCount();
            return Ok(value);
        }
        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            var value = _bookingService.TGetBookingCount();
            return Ok(value);
        }
        [HttpGet("GuestCount")]
        public IActionResult GuestCount()
        {
            var value = _guestService.TGetGuestCount();
            return Ok(value);
        }
        [HttpGet("UserCount")]
        public IActionResult UserCount()
        {
            var value = _appUsersServices.TAppUserCount();
            return Ok(value);
        }
    }
}
