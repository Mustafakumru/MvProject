using AutoMapper;
using HostelProject.WebUI.Dtos.AboutDto;
using HostelProject.WebUI.Dtos.AppUserDto;
using HostelProject.WebUI.Dtos.BookingDto;
using HostelProject.WebUI.Dtos.LoginDto;
using HostelProject.WebUI.Dtos.RegisterDto;
using HostelProject.WebUI.Dtos.ServiseDtos;
using HostelProject.WebUI.Dtos.SubscribeDto;
using HostelProject.WebUI.Dtos.TestimonialDto;
using HotelProject.EntitiyLayer.Concrate;

namespace HostelProject.WebUI.Mapper
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
            CreateMap< ResultAboutDto, About>().ReverseMap();
            CreateMap< UpdateAboutDto, About>().ReverseMap();
            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<ResultAddBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedResrvationDto, Booking>().ReverseMap();
            CreateMap<ResultAppUserDto,AppUser >().ReverseMap();
        }
    }
}
