﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class StaffManager : IStaffService
	{
		private readonly IStaffDal _staffDal;

		public StaffManager(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}

		public Staff TGetById(int id)
		{
			return _staffDal.GetById(id);	
		}

		public List<Staff> TGetList()
		{
			return _staffDal.GetList();	
		}

		public void TDelete(Staff t)
		{
			_staffDal.Delete(t);
		}

		public void TInsert(Staff t)
		{
			_staffDal.Insert(t);
		}

		public void TUpdate(Staff t)
		{
			_staffDal.Update(t);
		}

        public int TGetStaffCount()
        {
           return _staffDal.GetStaffCount();
        }
    }
}
