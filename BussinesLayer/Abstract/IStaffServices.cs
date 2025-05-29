using HotelProject.EntitiyLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IStaffServices:IGenericService<Staff>
    {
        int TGetStaffCount();
        List<Staff> TLast4Staf();
    }
}
