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
    public class StaffManager : IStaffServices
    {
        private readonly IStaffDal _staffDal;
        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void TDelete(Staff t)
        {
           _staffDal.delete(t);
        }

        public Staff TGetById(int id)
        {
           
            return _staffDal.GetById(id);
        }

        public List<Staff> TGetList()
        {
           return _staffDal.GetList();
        }

        public int TGetStaffCount()
        {
            return _staffDal.GetStaffCount();
        }

        public void TInsert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public List<Staff> TLast4Staf()
        {
          return _staffDal.Last4Staf();
        }

        public void TUpdate(Staff t)
        {
           _staffDal.update(t);
        }
    }
}
