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
    public class EfSendMesageDal : GenericRepository<SendMessage>, ISendMessageDal
    {
        public EfSendMesageDal(Context context) : base(context)
        {
        }

        public int GetSendMessageCount()
        {
           var context=new Context();
            return context.SendMessages.Count();
        }
    }
}
