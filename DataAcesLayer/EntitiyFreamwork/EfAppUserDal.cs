using DataAcesLayer.Abstract;
using DataAcesLayer.Concrate;
using DataAcesLayer.Repository;
using HotelProject.EntitiyLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcesLayer.EntitiyFreamwork
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {
        }

        public int AppUserCount()
        {
           var context=new Context();
           var values=context.Users.Count();
            return values;
        }

        public List<AppUser> UserListWithWorkLocation()
        {
            var context=new Context();
            return context.Users.Include(x => x.WorkLocation).ToList();
        }
    }
}
