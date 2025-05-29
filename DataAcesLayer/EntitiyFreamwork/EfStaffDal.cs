using DataAcesLayer.Abstract;
using DataAcesLayer.Concrate;
using DataAcesLayer.Repository;
using HotelProject.EntitiyLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcesLayer.EntitiyFreamwork
{
    public class EfStaffDal :GenericRepository<Staff>,IStaffDal
    {
        public EfStaffDal(Context context):base(context) { }

        public int GetStaffCount()
        {
            var context=new Context();
            var value=context.Staff.Count();
            return value;
        }

        public List<Staff> Last4Staf()
        {
            using var context=new Context();
            var value=context.Staff.OrderByDescending(x=>x.StaffID).Take(4).ToList();
            return value;
        }
    }
}
