﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntitiyLayer.Concrate
{
    public class WorkLocation
    {
        public int WorkLocationID { get; set; }
        public string WorkLocationName { get; set; }
        public string WorkLocationCity { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
