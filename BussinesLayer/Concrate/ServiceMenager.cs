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
    public class ServiceMenager : IServicesServices
    {
        private readonly IServicesDal _servicesDal;
        public ServiceMenager (IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }
        public void TDelete(Service t)
        {
            _servicesDal.delete(t);
        }

        public Service TGetById(int id)
        {
            return _servicesDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _servicesDal.GetList();
        }

        public void TInsert(Service t)
        {
           _servicesDal.Insert(t);
        }

        public void TUpdate(Service t)
        {
            _servicesDal.update(t);
        }
    }
}
