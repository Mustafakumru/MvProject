﻿using BussinesLayer.Abstract;
using HotelProject.EntitiyLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServicesServices _ServiceService;

        public ServiceController(IServicesServices ServiceService)
        {
            _ServiceService = ServiceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _ServiceService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddService(Service Service)
        {
            _ServiceService.TInsert(Service);

            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _ServiceService.TGetById(id);
            _ServiceService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service Service)
        {

            _ServiceService.TUpdate(Service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _ServiceService.TGetById(id);

            return Ok(values);

        }
    }
}

