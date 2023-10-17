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
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void TDelete(Guest delete)
        {
            _guestDal.Delete(delete);
        }

        public Guest TGetByID(int id)
        {
            return _guestDal.GetByID(id);
        }

        public List<Guest> TGetList()
        {
            return _guestDal.GetList();
        }

        public void TInsert(Guest insert)
        {
            _guestDal.Insert(insert);
        }

        public void TUpdate(Guest update)
        {
            _guestDal.Update(update);
        }
    }
}
