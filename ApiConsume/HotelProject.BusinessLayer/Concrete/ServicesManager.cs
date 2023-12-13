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
	public class ServicesManager : IServiceService
	{
		private readonly IServicesDal _servicesDal;

		public ServicesManager(IServicesDal servicesDal)
		{
			_servicesDal = servicesDal;
		}

		public Service TGetById(int id)
		{
			return _servicesDal.GetById(id);	
		}

		public List<Service> TGetList()
		{
			return _servicesDal.GetList();
		}

		public void TDelete(Service t)
		{
			_servicesDal.Delete(t);
		}

		public void TInsert(Service t)
		{
			_servicesDal.Update(t);
		}

		public void TUpdate(Service t)
		{
			_servicesDal.Update(t);
		}
	}
}
