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
    public class WorkLocationMenager : IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;
        public WorkLocationMenager(IWorkLocationDal workLocationDal)
        {
            _workLocationDal = workLocationDal;
        }
        public void TDelete(WorkLocation t)
        {
            _workLocationDal.delete(t);
        }

        public WorkLocation TGetById(int id)
        {
            return _workLocationDal.GetById(id);
        }

        public List<WorkLocation> TGetList()
        {
           return _workLocationDal.GetList();
        }

        public void TInsert(WorkLocation t)
        {
            _workLocationDal.Insert(t);
        }

        public void TUpdate(WorkLocation t)
        {
          _workLocationDal.update(t);
        }
    }
}
