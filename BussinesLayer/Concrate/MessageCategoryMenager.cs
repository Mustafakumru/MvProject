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
    public class MessageCategoryMenager : IMeesageCategoryService
    {
        public readonly IMesageCategoryDal _mesageCategoryDal;
        public MessageCategoryMenager(IMesageCategoryDal mesageCategoryDal)
        {
            _mesageCategoryDal = mesageCategoryDal;
        }

        public void TDelete(MessageCategory t)
        {
            _mesageCategoryDal.delete(t);
        }

        public MessageCategory TGetById(int id)
        {
            return _mesageCategoryDal.GetById(id);
        }

        public List<MessageCategory> TGetList()
        {
           return _mesageCategoryDal.GetList();
        }

        public void TInsert(MessageCategory t)
        {
           _mesageCategoryDal.Insert(t);
        }

        public void TUpdate(MessageCategory t)
        {
            _mesageCategoryDal.update(t);
        }
    }
}
