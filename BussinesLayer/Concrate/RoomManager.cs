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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomdal;
        public RoomManager(IRoomDal roomDal)
        {
            _roomdal=roomDal;
        }
        public void TDelete(Room t)
        {
            _roomdal.delete(t);
            

        }

        public Room TGetById(int id)
        {
            return _roomdal.GetById(id);
        }

        public List<Room> TGetList()
        {
            return _roomdal.GetList();
        }

        public void TInsert(Room t)
        {
            _roomdal.Insert(t);
        }

        public void TUpdate(Room t)
        {
            _roomdal.update(t);
        }
    }
   
}
