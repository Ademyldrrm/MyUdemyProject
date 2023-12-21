﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntiyFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {
        }

        public int GEtAppUserCount()
        {
            var contex = new Context();
            var value = contex.Users.Count();
            return value;
        }

        public List<AppUser> UserListWithWorkLocation()
        {
            var context=new Context();
            return context.Users.Include(x => x.WorkLocation).ToList();
        }

        public List<AppUser> UserListWithWorkLocations()
        {
            var context = new Context();
            var values= context.Users.Include(x => x.WorkLocation).ToList();
            return values;
        }
    }
}
