using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntitiyLayer.Concrate
{
    public class AppUser : IdentityUser<int>
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }
        public string ImgUrl { get; set; }
        public string WorkDepartment { get; set; }
        public int WorkLocationID { get; set; }
        public WorkLocation WorkLocation { get; set; }
    }
}
