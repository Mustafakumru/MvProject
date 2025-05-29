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
    public class EfServiceDal:GenericRepository<Service>,IServicesDal
    {
        public EfServiceDal(Context context):base(context) { }
       
    }
}
