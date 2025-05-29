using HotelProject.EntitiyLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IAppUsersServices:IGenericService<AppUser>
    {
        List<AppUser> TUserListWithWorkLocation();
        int TAppUserCount();
    }
}
