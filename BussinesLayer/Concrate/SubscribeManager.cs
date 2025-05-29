using BussinesLayer.Abstract;
using DataAcesLayer.Abstract;
using HotelProject.EntitiyLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrate
{
    public class SubscribeManager : ISubscribeServices
    {
        private readonly ISubscribeDal _subscribeDal;
        public SubscribeManager (ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }
        public void TDelete(Subscribe t)
        {
            _subscribeDal.delete(t);
        }

        public Subscribe TGetById(int id)
        {
            return _subscribeDal.GetById(id);
        }

        public List<Subscribe> TGetList()
        {
           return _subscribeDal.GetList();
        }

        public void TInsert(Subscribe t)
        {
           _subscribeDal.Insert(t);
        }

        public void TUpdate(Subscribe t)
        {
            _subscribeDal.update(t);
        }
    }
}
