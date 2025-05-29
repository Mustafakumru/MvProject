using AutoMapper;
using DtoLayer.Dtos.RoomDto;
using HotelProject.EntitiyLayer.Concrate;
//dto sınıfardaki proportyleri entity sınıfındakki proporty lerle eşleşme işlemini yapmış oluyoruz 
namespace HotelProject.WebApi.Maping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
