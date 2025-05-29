using AutoMapper;
using BussinesLayer.Abstract;
using DtoLayer.Dtos.RoomDto;
using HotelProject.EntitiyLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public Room2Controller(IMapper mapper, IRoomService roomService)
        {
            _mapper = mapper;
            _roomService = roomService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {
            //eğer model state vait değilse olumsuz istek dön
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values=_mapper.Map<Room>(roomAddDto);
             _roomService.TInsert(values);
           return Ok("Başarılı Şekilde Eklendi");

        }
        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto updateroomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(updateroomDto);
            _roomService.TUpdate(values);
            return Ok("Başarı İle Güncellendi");
        }
    }
   
}
