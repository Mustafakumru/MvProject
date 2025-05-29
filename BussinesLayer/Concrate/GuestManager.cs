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
    public class GuestManager : IGuestService
    {
        public readonly IGuestDal _guestDal;
        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void TDelete(Guest t)
        {
           _guestDal.delete(t);
        }

        public Guest TGetById(int id)
        {
          return _guestDal.GetById(id);
        }

        public int TGetGuestCount()
        {
            return _guestDal.GetGuestCount();
        }

        public List<Guest> TGetList()
        {
           return _guestDal.GetList();
        }

        public void TInsert(Guest t)
        {
            _guestDal.Insert(t);
        }

        public void TUpdate(Guest t)
        {
          
            _guestDal.update(t);
        }
    }
}
