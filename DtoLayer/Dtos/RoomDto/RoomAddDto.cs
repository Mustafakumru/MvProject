using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {

        [Required(ErrorMessage ="Lütfen Oda Numarası Giriniz")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required (ErrorMessage ="Lütfen Fiat Başlığı giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda  Başlığı  bilgisi giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen oda sayısı giriniz")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
