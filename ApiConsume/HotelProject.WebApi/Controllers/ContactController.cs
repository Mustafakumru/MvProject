﻿using BussinesLayer.Abstract;
using HotelProject.EntitiyLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpPost]
        public IActionResult AddBooking(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.TInsert(contact);

            return Ok();
        }
        [HttpGet]
        public IActionResult InboxListContact()
        {
          
                var values = 
                _contactService.TGetList();
                return Ok(values);
            
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _contactService.TGetById(id);
            return Ok(values);
        }
        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount() {
        
          return Ok(_contactService.TGetContactCount());
        }

    }
}
