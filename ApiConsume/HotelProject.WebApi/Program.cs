using BussinesLayer.Abstract;
using BussinesLayer.Concrate;
using DataAcesLayer.Abstract;
using DataAcesLayer.Concrate;
using DataAcesLayer.EntitiyFreamwork;
using HotelProject.EntitiyLayer.Concrate;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders();
// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Burada ConfigureServices metodunun içeriðini ekleyin
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IServicesDal, EfServiceDal>();
builder.Services.AddScoped<IServicesServices,ServiceMenager>();
builder.Services.AddScoped<IStaffDal, EfStaffDal>();
builder.Services.AddScoped<IStaffServices, StaffManager>();
builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeServices, SubscribeManager>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialServices, TestimonialManager>();
builder.Services.AddScoped<IRoomDal, EfRoomDal>();
builder.Services.AddScoped<IRoomService, RoomManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IAboutService, AboutMenager>();
builder.Services.AddScoped<IBookingDal,EfBookingDal>();
builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactMenager>();
builder.Services.AddScoped<IGuestDal, EfGuestDal>();
builder.Services.AddScoped<IGuestService, GuestManager>();
builder.Services.AddScoped<ISendMessageDal, EfSendMesageDal>();
builder.Services.AddScoped<ISendMessageService, SendMessageManager>();
builder.Services.AddScoped<IMesageCategoryDal, EfMesageCategoryDal>();
builder.Services.AddScoped<IMeesageCategoryService, MessageCategoryMenager>();
builder.Services.AddScoped<IWorkLocationDal, EfWorkLocationDal>();
builder.Services.AddScoped<IWorkLocationService, WorkLocationMenager>();
builder.Services.AddScoped<IAppUserDal,EfAppUserDal>();
builder.Services.AddScoped<IAppUsersServices, AppUserMenager>();



builder.Services.AddAutoMapper(typeof(Program));
//builder.Services.AddScoped
// CORS politikasýný ekleyin
builder.Services.AddCors(opt => {
    opt.AddPolicy("OtelApiCors", opts => {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Swagger'ý kullanýlabilir hale getirin
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}

// CORS'ý etkinleþtirin
app.UseCors("OtelApiCors");

app.UseAuthorization();
app.MapControllers();
app.Run();
