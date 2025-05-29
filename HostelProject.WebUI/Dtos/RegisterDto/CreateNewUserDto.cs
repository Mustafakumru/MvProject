using System.ComponentModel.DataAnnotations;

namespace HostelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Alanı Gereklidir") ]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Soyad Alanı Gereklidir")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mail Alanı Gereklidir")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Sıfre Alanı Gereklidir")]
        public string Sıfre { get; set; }

        [Required(ErrorMessage = "Sıfre Tekrar Alanı Gereklidir")]
        [Compare("Sıfre",ErrorMessage ="Şifreler Uyuşmadı")]
        public string SıfreTekrar { get; set; }

    }
}
