using BussinesLayer.Abstract;
using HotelProject.EntitiyLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class  StaffController : ControllerBase
    {
        private readonly IStaffServices _staffServices;

        public StaffController(IStaffServices staffServices)
        {
            _staffServices = staffServices;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var  values=_staffServices.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffServices.TInsert(staff);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var valuse=_staffServices.TGetById(id);
            _staffServices.TDelete(valuse);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffServices.TUpdate(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values = _staffServices.TGetById(id);
            return Ok(values);
        }
        [HttpGet("Last4Staf")]
        public IActionResult Last4Staf()
        {
            var values = _staffServices.TLast4Staf();
            return Ok(values);
        }

    }
}
