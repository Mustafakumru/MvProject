﻿using BussinesLayer.Abstract;
using DataAcesLayer.Abstract;
using HotelProject.EntitiyLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrate
{
    public class ContactMenager : IContactService

    {
        private readonly IContactDal? _contactDal;
        public ContactMenager(IContactDal contactDal)
        {
            _contactDal= contactDal;
        }
        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public int TGetContactCount()
        {
            return _contactDal.GetContactCount();
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TInsert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
