using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcesLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void delete(T t);
        void update(T t);
        List<T> GetList();
        T GetById(int id);
    }
}
