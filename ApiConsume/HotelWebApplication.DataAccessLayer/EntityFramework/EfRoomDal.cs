using HotelWebApplication.DataAccessLayer.Abstract;
using HotelWebApplication.DataAccessLayer.Concrete;
using HotelWebApplication.DataAccessLayer.Repositories;
using HotelWebApplication.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWebApplication.DataAccessLayer.EntityFramework
{
    public class EfRoomDal : GenericRepository<Room>, IRoomDal
    {
        public EfRoomDal(Context context) : base(context)
        {
        }
    }
}
