﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntiyFramework
{
	public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
	{
		public EfSubscribeDal(Context context) : base(context)
		{
		}
	}
}
