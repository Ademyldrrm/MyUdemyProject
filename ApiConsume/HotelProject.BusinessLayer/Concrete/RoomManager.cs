using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class RoomManager : IRoomService
	{
		IRoomDal _roomDal;

		public RoomManager(IRoomDal roomDal)
		{
			_roomDal = roomDal;
		}

		public Room TGetById(int id)
		{
			return _roomDal.GetById(id);	
		}

		public List<Room> TGetList()
		{
			return _roomDal.GetList();
		}

		public void TDelete(Room t)
		{
			_roomDal.Delete(t);
		}

		public void TInsert(Room t)
		{
			_roomDal.Insert(t);
		}

		public void TUpdate(Room t)
		{
			_roomDal.Update(t);
		}
	}
}
