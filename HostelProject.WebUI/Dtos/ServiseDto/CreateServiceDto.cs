using System.ComponentModel.DataAnnotations;

namespace HostelProject.WebUI.Dtos.ServiseDtos
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Servis İcon linki Giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Servis başlığı giriniz Giriniz")]
        [StringLength(35,ErrorMessage ="Service Başlığı en fazla 35 karaktr olabilirr ")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Servis açıklaması giriniz Giriniz")]
        [StringLength(120, ErrorMessage = "Service açıklaması  en fazla 120 karaktr olabilirr ")]
        public string Description { get; set; }
    }
}
